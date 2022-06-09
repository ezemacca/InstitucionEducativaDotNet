using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class EliminarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    public EliminarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }
    public void  Ejecutar(Inscripcion UnaInscripcion)
    {
        _rInscripcion.EliminarInscripcion(UnaInscripcion);
    }
}