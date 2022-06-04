namespace AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public interface IRepositorioEstudiante
{
    List<Estudiante> GetEstudiantes();
    void ModificarEstudiante(Estudiante estudiante);
    void EliminarEstudiante(Estudiante estudiante);
    void AgregarEstudiante(Estudiante estudiante);

    List<Estudiante> EstudiantesCursandoActualmente();

    List<Estudiante> EstudiantesConCursosFinalizados();

}