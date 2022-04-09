
using Curso.API.Business.Entities;
using System;
using System.Collections.Generic;

namespace Curso.API.Business.Repositories
{
    //Abstração de CursoRepository classe
    public interface ICursoRepository
    {
        void Adicionar(Entities.Curso curso);
        void Commit();
        IList<Entities.Curso> ObterPorUsuario(int codigoUsuario);
    }
}
