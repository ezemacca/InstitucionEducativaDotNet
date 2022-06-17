using AL.Aplicacion.Entidades;
namespace AL.Aplicacion.Interfaces;

public interface IRepositorioCurso
{
    Curso? GetCurso(int idCurso);
    /* Dado un estudiante, devuelve una lista de cursos a los que está inscripto el estudiante */
    List<Curso>? GetCursosInscriptos(int id_estudiante);
    List<Curso>? GetCursos();
    void ModificarCurso(Curso curso);
    void EliminarCurso(int curso);
    void AgregarCurso(Curso curso);

}