using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class GetEstudiantesConUnCursoFinalizadoUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public GetEstudiantesConUnCursoFinalizadoUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantesConUnCursoFinalizado();
    }
}