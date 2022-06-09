using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class EliminarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;
    public EliminarCursoUseCase (IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }
    public void  Ejecutar(Curso UnCurso)
    {
        _rCurso.EliminarCurso(UnCurso);
    }
}