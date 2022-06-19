using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class GetEstudiantesAunCursandoUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public GetEstudiantesAunCursandoUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantesCursandoActualmente();
    }
}