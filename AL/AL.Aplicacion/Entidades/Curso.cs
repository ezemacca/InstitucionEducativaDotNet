namespace AL.Aplicacion.Entidades;

public class Curso 
{
    public int Id {get; set;}
    public string Titulo {get; set;}="";
    public string Descripcion {get; set;}="";
    public DateTime FechaInicio{get; set;}
    public DateTime FechaFin{get; set;}

    public List<Inscripcion>? Inscripciones {get; set;}

}