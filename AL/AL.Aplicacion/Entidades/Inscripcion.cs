namespace AL.Aplicacion.Entidades;

public class Inscripcion
{
    public int Id {get;set;}
    public int estudiante_id {get;set;}
    public int Curso_id {get;set;}
    public DateOnly FechaInscripcion{get;set;}
    public Curso? Curso {get;set;}
    public Estudiante? Estudiante{get;set;}

}