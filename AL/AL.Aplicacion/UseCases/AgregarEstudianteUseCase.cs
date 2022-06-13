using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class AgregarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public AgregarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante= rEstudiante;
    }

    public void Ejecutar(Estudiante estudiante)
    {
        _rEstudiante.AgregarEstudiante(estudiante);
    }
}