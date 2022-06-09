using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class GetCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;
    public GetCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }
    public Curso Ejecutar(int id)
    {
        return _rCurso.GetCurso(id);
    }

}