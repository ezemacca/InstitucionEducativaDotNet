using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
namespace AL.Repositorios;
public class RepositorioCurso : IRepositorioCurso
{

    public void AgregarCurso(Curso curso) 
    {

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

    public List<Curso> GetCursos()
    {
        throw new NotImplementedException();
    }

    public void ModificarCurso(Curso curso)
    {
        throw new NotImplementedException();
    }
}