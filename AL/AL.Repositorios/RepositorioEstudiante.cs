using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios;

public class RepositorioEstudiante : IRepositorioEstudiante
{
    public void AgregarEstudiante(Estudiante estudiante)
    {
        using(var context = new InstitucionEducativaContext())
        {
            context.Add(estudiante);
            context.SaveChanges();
        }
    }

    public void EliminarEstudiante(int id)
    {
        var estudianteBorrar= GetEstudiante(id);
        using(var context = new InstitucionEducativaContext())
        {
            if(estudianteBorrar != null)
            {
                context.Remove(estudianteBorrar);
                context.SaveChanges();
            }
        }
    }

    public Estudiante? GetEstudiante(int id)
    {
        using(var context = new InstitucionEducativaContext())
        {
            var estudiante= context.Estudiantes.Where(e => e.Id == id).Include(e => e.Inscripciones).ThenInclude(i => i.Curso).SingleOrDefault();
            return estudiante;
        }
    }

    public void ModificarEstudiante(Estudiante estudiante)
    {
        using(var context = new InstitucionEducativaContext())
        {
            context.Update(estudiante);
            context.SaveChanges();
        }
    }

    public List<Estudiante> GetEstudiantes()
    {
        
        using(var context = new InstitucionEducativaContext())
        {
            context.Database.EnsureCreated();
            return context.Estudiantes.Include(e => e.Inscripciones).ToList();
        }
    }

    public List<Estudiante> GetEstudiantesCursandoActualmente()
    {
        using(var context = new InstitucionEducativaContext())
        {
            //  List<Estudiante> estudiantes= new List<Estudiante>();

            // List<Curso> cursosActivos= context.Cursos
            //     .Include(c => c.Inscripciones)
            //     .ThenInclude(i => i.Estudiante)
            //     .Where(cur => cur.FechaInicio < DateTime.Now && cur.FechaFin > DateTime.Now)
            //     .ToList();
                
            // cursosActivos.ForEach(c => c.Inscripciones.ForEach(i => estudiantes.Add(new Estudiante(){ Nombre=i.Estudiante.Nombre, Apellido=i.Estudiante.Apellido, Inscripciones= new List<Inscripcion>(){i}})));
            // return estudiantes;  
            
            List<Estudiante> estudiantes= context.Estudiantes.Include(est => est.Inscripciones).ThenInclude(ins=> ins.Curso).ToList();
            List<Estudiante> estudiantes_cursando= new List<Estudiante>();
            foreach (Estudiante e in estudiantes){
                if(e.Inscripciones!=null){
                    foreach(Inscripcion i in e.Inscripciones){
                        // si el curso esta activo
                        if((i.Curso!= null) && (i.Curso.FechaInicio<DateTime.Now && i.Curso.FechaFin>DateTime.Now)){
                            // Si el estudiante no estaba en la lista 
                            if(estudiantes_cursando.Find(est=> est.DNI==e.DNI)==null){
                                estudiantes_cursando.Add(
                                    new Estudiante()
                                    {   
                                        Nombre=e.Nombre, 
                                        Apellido=e.Apellido, 
                                        Inscripciones= new List<Inscripcion>(){i}
                                    }
                                );
                            }
                            else
                            {
                                estudiantes_cursando.Find(est=> est.DNI==e.DNI).Inscripciones.Add(i);
                                
                            }
                        }
                    }
                }
            }
            context.SaveChanges();
            return estudiantes_cursando;
 

        }
        return null;
    }

    public List<Estudiante> GetEstudiantesConUnCursoFinalizado()
    {
        using(var context = new InstitucionEducativaContext())
        {
            List<Estudiante> estudiantesAntiguos= new List<Estudiante>();
            List<Curso> cursosTerminados= context.Cursos.Include(c => c.Inscripciones)
                .ThenInclude(i => i.Estudiante)
                .Where(cur => cur.FechaFin  < DateTime.Now)
                .ToList();
            cursosTerminados.ForEach(c => c.Inscripciones.ForEach(i => estudiantesAntiguos.Add(new Estudiante(){ Nombre=i.Estudiante.Nombre, Apellido=i.Estudiante.Apellido, Inscripciones= new List<Inscripcion>(){i}})));
            return estudiantesAntiguos;           
        }
        return null;
    }
}