namespace AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;

public interface IRepositorioInscripcion
{
    List<Inscripcion> GetInscripcion();
    void ModificarInscripcion(Inscripcion Inscripcion);
    void EliminarInscripcion(Inscripcion Inscripcion);
    void AgregarInscripcion(Inscripcion Inscripcion);

    

}