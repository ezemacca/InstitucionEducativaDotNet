using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class GetCursosUseCase
{
    private readonly IRepositorioCurso _rCurso;
    public GetCursosUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }
    public  List<Curso> Ejecutar(int id)
    {
        return _rCurso.GetCursos(id);
    }
}