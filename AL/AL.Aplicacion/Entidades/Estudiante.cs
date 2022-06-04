namespace AL.Aplicacion.Entidades;

public class Estudiante
{
    public int Id {get;set;}
    public int DNI {get;set;}
    public string Nombre {get;set;}="";
    public string Apellido {get;set;}="";
    public string Mail {get;set;}="";

    public List<Inscripcion> Inscripciones {get;set;}
}