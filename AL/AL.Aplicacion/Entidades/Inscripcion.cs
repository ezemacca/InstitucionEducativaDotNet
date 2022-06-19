namespace AL.Aplicacion.Entidades;

public class Inscripcion
{
    public int Id {get;set;}
    public int estudianteId {get;set;}
    public int CursoId {get;set;}
    public DateOnly FechaInscripcion{get;set;}
    public Curso? Curso {get;set;}
    public Estudiante? Estudiante{get;set;}

}