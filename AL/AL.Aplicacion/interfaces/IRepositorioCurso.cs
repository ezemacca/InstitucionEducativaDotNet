using AL.Aplicacion.Entidades;
namespace AL.Aplicacion.Interfaces;

public interface IRepositorioCurso
{
    Curso? GetCurso();
    List<Curso> GetCursos();
    void ModificarCurso(Curso curso);
    void EliminarCurso(Curso curso);
    void AgregarCurso(Curso curso);

}