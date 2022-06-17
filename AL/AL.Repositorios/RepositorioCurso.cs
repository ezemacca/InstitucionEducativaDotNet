using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;

namespace AL.Repositorios;

public class RepositorioCurso : IRepositorioCurso
{
    public void AgregarCurso(Curso curso)
    {
        using(var context = new InstitucionEducativaContext())
        {
            context.Add(curso);
            context.SaveChanges();
        }
    }
    
    public void EliminarCurso(int id)
    {
        using(var context = new InstitucionEducativaContext())
        {
            var cursoBorrar= context.Cursos.Where(c => c.Id == id).SingleOrDefault();
            if(cursoBorrar != null)
            {
                context.Remove(cursoBorrar);
                context.SaveChanges();
            }
        }
    }

    public Curso? GetCurso(int id)
    {
        using(var context= new InstitucionEducativaContext())
        {
            /* Los datos relacionados del curso (inscripcion y estudiantes) 
            se incluyen explícitamente con los .Include*/
            var curso= context.Cursos
                        .Where(c => c.Id == id)
                        .Include(c => c.Inscripciones)
                        .ThenInclude(i => i.Estudiante)
                        .SingleOrDefault();
            return curso;
        }
    }

    public List<Curso>? GetCursos()
    {
        using(var context= new InstitucionEducativaContext())
        {
            var listaCursos= context.Cursos.Include(c => c.Inscripciones).ToList();
            return listaCursos;
        }    
    }

    public List<Curso>? GetCursosInscriptos(int id_estudiante)
    {
        using(var context= new InstitucionEducativaContext())
        {
            // var listaCursos= context.Cursos.Include(c => c.Inscripciones).ToList();
            
            var lista_inscripciones= context.Inscripciones.Where( i=> i.estudiante_id==id_estudiante).ToList();
            
            List<Curso>? listaCursosInscriptos=new List<Curso>();
            foreach (Inscripcion i in lista_inscripciones ) {
                Curso? curso= context.Cursos.Where(c=> c.Id==i.Curso_id).SingleOrDefault();
                if(curso!=null){
                    listaCursosInscriptos.Add(curso);
                }
            }
            return listaCursosInscriptos;
        }
    }

    public void ModificarCurso(Curso curso)
    {
        using(var context= new InstitucionEducativaContext())
        {
            context.Cursos.Update(curso);
            context.SaveChanges();
        }
    }
}