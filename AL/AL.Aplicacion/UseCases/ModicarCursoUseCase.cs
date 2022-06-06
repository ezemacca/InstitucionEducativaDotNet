using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Aplicacion.UseCases;
public class ModificarCursoUseCase
{
private readonly IRepositorioCurso _rCurso;
public ModificarCursoUseCase(IRepositorioCurso rCurso)
{
    _rCurso = rCurso;
}

public void Ejecutar (Curso curso)
{   
    _rCurso.ModificarCurso(curso);s
}

}