using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class ModificarEstudianteUseCase
    {
    private readonly IRepositorioEstudiante _rEstudiante;
    public ModificarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar (Estudiante estudiante)
    {   
        _rEstudiante.ModificarEstudiante(estudiante);
    }

}