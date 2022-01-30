using _01_Northwnd.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericRepository.Repository
{
    public class GenericRepository<T> where T : class
    {
        private readonly NORTHWNDEntities _context;
        private readonly IDbSet<T> _dbSet;

        public GenericRepository()
        {
            _context = new NORTHWNDEntities();
            _dbSet = _context.Set<T>();
        }

        //CRUD, Create, Read (Get, GetAll), Update, Delete

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
