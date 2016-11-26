using LeilaoFabrica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace LeilaoFabrica.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region FIELDS
        protected LeilaoContext _context;
        protected DbSet<T> _dbset;
        #endregion

        public GenericRepository(LeilaoContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public void Alterar(T entidade)
        {
            _context.Entry(entidade).State = EntityState.Modified;
        }

        public ICollection<T> BuscaPor(Expression<Func<T, bool>> filtro)
        {
            return _dbset.Where(filtro).ToList();
        }

        public T BuscarPorId(int id)
        {
            return _dbset.Find(id);
        }

        public void Cadastrar(T entidade)
        {
            _context.Entry(entidade).State = EntityState.Added;
        }

        public ICollection<T> Listar()
        {
            return _dbset.ToList();
        }

        public void Remover(int id)
        {
            _dbset.Remove(BuscarPorId(id));
        }
    }
}