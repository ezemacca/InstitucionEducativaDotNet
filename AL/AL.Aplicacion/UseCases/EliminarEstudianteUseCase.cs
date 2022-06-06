using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class EliminarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;
    public EliminarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }
    public void  Ejecutar(Estudiante UnEstudiante)
    {
        _rEstudiante.EliminarEstudiante(UnEstudiante);

    }
}