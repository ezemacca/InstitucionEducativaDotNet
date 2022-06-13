using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios;

public class RepositorioCurso : IRepositorioCurso
{
    public void AgregarCurso(Curso curso)
    {
        using(var context = new InstitucionEducativaContext())
        {
            context.Database.EnsureCreated();
            context.Add(curso);
            context.SaveChanges();
        }
    }
    public List<Curso> GetCursos(int id)
    {
        throw new NotImplementedException();
    }
    public void EliminarCurso(int id)
    {
        using(var context = new InstitucionEducativaContext())
        {
            var cursoBorrar= context.Cursos.Where(c => c.Id == id).SingleOrDefault();
            if(cursoBorrar != null)
            {
                context.Remove(cursoBorrar);
                context.SaveChanges();
            }
        }
    }

    public Curso? GetCurso(int id)
    {
        using(var context= new InstitucionEducativaContext())
        {
            var curso= context.Cursos.Where(c => c.Id == id).Include(c => c.Inscripciones).ThenInclude(i => i.Estudiante).SingleOrDefault();
            return curso;
        }
    }

    public List<Curso> GetCursos()
    {
        using(var context= new InstitucionEducativaContext())
        {
            var listaCursos= context.Cursos.Include(c => c.Inscripciones).ToList();
            return listaCursos;
        }
    }

    public void ModificarCurso(Curso curso)
    {
        using(var context= new InstitucionEducativaContext())
        {
            context.Cursos.Update(curso);
            context.SaveChanges();
        }
    }
}