using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class AgregarCursoUseCase
{
private readonly IRepositorioCurso_rCurso;
public AgregarCursoUseCase(IRepositorioCurso rCurso)
{
    _rCurso = rCurso;

}
public List<Curso> Ejecutar()
{
    
return _rCurso.GetCursos();
}
}