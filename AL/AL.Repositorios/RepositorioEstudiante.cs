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

    public List<Estudiante> GetEstudiantes(int id_curso)
    {
        using(var context = new InstitucionEducativaContext())
        {
            return context.Estudiantes.Include(e => e.Inscripciones).ToList();
        }
    }

    public List<Estudiante> GetEstudiantesCursandoActualmente()
    {
        using(var context = new InstitucionEducativaContext())
        {
            // // no se como hacer la consulta.
            // List<Estudiante> estudiantesEstudiando= new List<Estudiante>();
            // List<Curso> cursosActivos= context.Cursos.Include(c => c.Inscripciones)
            //     .ThenInclude(i => i.Estudiante)
            //     .Where(cur => cur.Fecha_inicio < DateTime.Now && cur.Fecha_finalizacion > DateTime.Now)
            //     .ToList();
            // cursosActivos.ForEach(c => c.Inscripciones.ForEach(i => estudiantesEstudiando.Add(new Estudiante(){ Nombre=i.Estudiante.Nombre, Apellido=i.Estudiante.Apellido, Inscripciones= new List<Inscripcion>(){i}})));
            // return estudiantesEstudiando;      
        }
        return null;
    }

    public List<Estudiante> EstudiantesConUnCursoFinalizado()
    {
        using(var context = new InstitucionEducativaContext())
        {
            // List<Estudiante> estudiantesAntiguos= new List<Estudiante>();
            // List<Curso> cursosTerminados= context.Cursos.Include(c => c.Inscripciones)
            //     .ThenInclude(i => i.Estudiante)
            //     .Where(cur => cur.Fecha_finalizacion < DateTime.Now)
            //     .ToList();
            // cursosTerminados.ForEach(c => c.Inscripciones.ForEach(i => estudiantesAntiguos.Add(new Estudiante(){ Nombre=i.Estudiante.Nombre, Apellido=i.Estudiante.Apellido, Inscripciones= new List<Inscripcion>(){i}})));
            // return estudiantesAntiguos;           
        }
        return null;
    }
}