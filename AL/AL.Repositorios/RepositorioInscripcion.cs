using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios;

public class RepositorioInscripcion : IRepositorioInscripcion
{
    public void AgregarInscripcion(Inscripcion inscripcion)
    {
        using(var context = new InstitucionEducativaContext())
        {
            //context.ChangeTracker.TrackGraph(inscripcion, node => node.Entry.State= !node.Entry.IsKeySet ? EntityState.Added : EntityState.Unchanged);
            context.Add(inscripcion);
            context.SaveChanges();
        }
    }

    public void EliminarInscripcion(int id)
    {
        var inscripcionBorrar= GetInscripcion(id);
        using(var context = new InstitucionEducativaContext())
        {
            if(inscripcionBorrar != null)
            {
                context.Remove(inscripcionBorrar);
                context.SaveChanges();
            }
        }
    }

    public Inscripcion? GetInscripcion(int id)
    {
        using(var context = new InstitucionEducativaContext())
        {
            var inscripcion = context.Inscripciones.Where(i => i.Id == id).Include(i => i.Curso).Include(i => i.Estudiante).SingleOrDefault();
            return inscripcion;
        }
    }

    public List<Inscripcion> GetInscripciones()
    {
        using(var context = new InstitucionEducativaContext())
        {
            List<Inscripcion> listaInscripciones= context.Inscripciones.Include(i => i.Curso).Include(i => i.Estudiante).ToList();
            return listaInscripciones;
        }
    }

    public void ModificarInscripcion(Inscripcion inscripcion)
    {
        using(var context = new InstitucionEducativaContext())
        {
            //context.Update(inscripcion);
            context.Entry(inscripcion).State= EntityState.Modified;
            context.SaveChanges();
        }
    }
}