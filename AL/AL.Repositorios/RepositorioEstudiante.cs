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
                                        DNI=e.DNI, 
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
    }

    public List<Estudiante> GetEstudiantesConUnCursoFinalizado()
    {
       using(var context = new InstitucionEducativaContext())
        {
            
            List<Estudiante> estudiantes= context.Estudiantes.Include(est => est.Inscripciones).ThenInclude(ins=> ins.Curso).ToList();
            List<Estudiante> e_curso_finalizado= new List<Estudiante>();
            foreach (Estudiante e in estudiantes){
                if(e.Inscripciones!=null){
                    foreach(Inscripcion i in e.Inscripciones){
                        // si el curso esta activo
                        if((i.Curso!= null) && (i.Curso.FechaFin<DateTime.Now)){
                            // Si el estudiante no estaba en la lista 
                            if(e_curso_finalizado.Find(est=> est.DNI==e.DNI)==null){
                                e_curso_finalizado.Add(
                                    new Estudiante()
                                    {   
                                        Nombre=e.Nombre, 
                                        Apellido=e.Apellido,
                                        DNI=e.DNI, 
                                        Inscripciones= new List<Inscripcion>(){i}
                                    }
                                );
                            }
                            else
                            {
                                e_curso_finalizado.Find(est=> est.DNI==e.DNI).Inscripciones.Add(i);
                            }
                        }
                    }
                }
            }
            context.SaveChanges();
            return e_curso_finalizado;
        }
    }   
}