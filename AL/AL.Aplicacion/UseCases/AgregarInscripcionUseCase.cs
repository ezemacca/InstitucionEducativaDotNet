using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class AgregarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    public AgregarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }
    public void  Ejecutar(Inscripcion UnaInscripcion)
    {
        _rInscripcion.AgregarInscripcion(UnaInscripcion);
    
    }
}