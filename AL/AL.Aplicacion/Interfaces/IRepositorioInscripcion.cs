namespace AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public interface IRepositorioInscripcion
{
    List<Inscripcion> GetInscripciones();
    Inscripcion? GetInscripcion(int id);
    void ModificarInscripcion(Inscripcion Inscripcion);
    void EliminarInscripcion(int id_inscripcion);
    void AgregarInscripcion(Inscripcion Inscripcion);
}