using Microsoft.EntityFrameworkCore;

namespace AL.Aplicacion.Entidades;

public class InstitucionEducativaContext : DbContext
{
    #nullable disable
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    #nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Escuela.sqlite");
    }
}