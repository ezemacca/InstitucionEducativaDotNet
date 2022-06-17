using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;

public class GetInscripcionesUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public GetInscripcionesUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion= rInscripcion;
    }

    public List<Inscripcion> Ejecutar()
    {
        return _rInscripcion.GetInscripciones();
    }
}