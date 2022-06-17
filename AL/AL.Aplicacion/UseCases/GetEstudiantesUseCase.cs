using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class GetEstudiantesUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;
    public GetEstudiantesUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }
    public  List<Estudiante> Ejecutar()
    {
        return _rEstudiante.GetEstudiantes();
    }
}