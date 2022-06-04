namespace AL.Aplicacion.Entidades;

public class Curso 
{
    public int Id {get;set;}
    public string Titulo {get;set;}
    public string Descripcion {get;set;}="";
    public DateOnly FechaInicio{get;set;};
    public DateOnly FechaFin{get;set;};

}