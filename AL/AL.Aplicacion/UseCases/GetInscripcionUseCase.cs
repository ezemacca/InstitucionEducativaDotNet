using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class GetInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    public GetInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }
    public  Inscripcion Ejecutar(int id)
    {
        return _rInscripcion.GetInscripcion(id);
    }
}