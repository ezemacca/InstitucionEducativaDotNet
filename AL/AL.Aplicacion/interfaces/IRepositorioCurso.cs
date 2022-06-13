using AL.Aplicacion.Entidades;
namespace AL.Aplicacion.Interfaces;

public interface IRepositorioCurso
{
    Curso? GetCurso(int idCurso);
    /* Dado un estudiante, devuelve una lista de cursos a los que está inscripto el estudiante */
    List<Curso> GetCursos(int id_estudiante);
    void ModificarCurso(Curso curso);
    void EliminarCurso(int curso);
    void AgregarCurso(Curso curso);

}