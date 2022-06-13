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
    // Para eliminar sólo necesitamos el id del curso
    public void  Ejecutar(int id_curso)
    {
        _rCurso.EliminarCurso(id_curso);
    }
}