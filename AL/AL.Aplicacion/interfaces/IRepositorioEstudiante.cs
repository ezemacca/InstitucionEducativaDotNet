namespace AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public interface IRepositorioEstudiante
{
    /* Dado un id de curso, devuelve los estudiantes inscriptos en ese curso */
    List<Estudiante> GetEstudiantes();
    Estudiante? GetEstudiante(int id);
    void ModificarEstudiante(Estudiante estudiante);
    void EliminarEstudiante(int id_estudiante);
    void AgregarEstudiante(Estudiante estudiante);


    List<Estudiante> EstudiantesConUnCursoFinalizado();
    List<Estudiante> GetEstudiantesCursandoActualmente();

}