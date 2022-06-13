namespace AL.Repositorios;

using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class RepositorioCurso : IRepositorioCurso
{

    public void AgregarCurso(Curso unCurso)
    {
        using (var context = new InstitucionEducativaContext())
        {
            context.Database.EnsureCreated();
            // context.Add(unCurso);
            // context.SaveChanges();
        }
    }

    public void EliminarCurso(int id) 
    {

    }

    public void EliminarCurso(Curso curso)
    {
        throw new NotImplementedException();
    }

    public Curso? GetCurso()
    {
        throw new NotImplementedException();
    }

    public Curso? GetCurso(int idCurso)
    {
        throw new NotImplementedException();
    }

    public List<Curso> GetCursos()
    {
        throw new NotImplementedException();
    }

    public List<Curso> GetCursos(int id_estudiante)
    {
        throw new NotImplementedException();
    }

    public void ModificarCurso(Curso curso)
    {
        throw new NotImplementedException();
    }
}