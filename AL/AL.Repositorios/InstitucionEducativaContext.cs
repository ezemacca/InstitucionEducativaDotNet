using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Repositorios;

namespace AL.Repositorios;

public class InstitucionEducativaContext : DbContext
{

    #nullable disable
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }

    public DbSet<Estudiante> Estudiantes { get; set; }
    #nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseSqlite("data source=InstitucionEducativa.sqlite");
    }
}