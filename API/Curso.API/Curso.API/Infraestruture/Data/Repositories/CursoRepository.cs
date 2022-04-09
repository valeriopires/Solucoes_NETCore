
using Curso.API.Business.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Curso.API.Infraestruture.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly CursoDbContext _contexto;

        public CursoRepository(CursoDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Business.Entities.Curso curso)
        {
            _contexto.Curso.Add(curso);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public IList<Business.Entities.Curso> ObterPorUsuario(int codigoUsuario)
        {
            return _contexto.Curso.Include(u => u.Usuario).Where(curso => curso.CodigoUsuario == codigoUsuario).ToList();
        }
    }
}
