using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class ModificarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    public ModificarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar (Inscripcion inscripcion)
    {   
        _rInscripcion.ModificarInscripcion(inscripcion);
    }

}