using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class GetCursosInscriptosUseCase
{
    private readonly IRepositorioCurso _rCurso;
    public GetCursosInscriptosUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }
    public  List<Curso>? Ejecutar(int id_estudiante)
    {
        return _rCurso.GetCursosInscriptos(id_estudiante);
    }
}