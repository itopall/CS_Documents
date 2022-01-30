using _01_Northwnd.Data;
using _03_UnitOfWorkveGenericRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_UnitOfWorkveGenericRepository.UnitOfWork
{
    public class UnitOfWorkGenericRepository : IDisposable
    {
        #region Variable
        private readonly NORTHWNDEntities _context;
        #endregion

        #region Ctor
        public UnitOfWorkGenericRepository()
        {
            _context = new NORTHWNDEntities();
        }
        #endregion

        #region Repository
        public GenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }
        #endregion

        #region Transactions
        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CurrentTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            _context.Database.CurrentTransaction.Rollback();
        }

        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                //Hata var ise loglama vs. yapılabilir.
                throw;
            }
        }
        #endregion

        #region Disposable
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }

        ~UnitOfWorkGenericRepository()
        {
            Dispose(false);
        }
        #endregion
    }
}
