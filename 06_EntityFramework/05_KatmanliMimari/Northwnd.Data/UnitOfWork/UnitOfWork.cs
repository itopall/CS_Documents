using Northwnd.Data.Context;
using Northwnd.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        #region Variable
        private readonly NORTHWNDEntities _context;

        private CategoriesRepository _categoriesRepository = null;
        private ProductsRepository _productsRepository = null;
        private EmployeesRepository _employeesRepository = null;
        #endregion

        #region Ctor
        public UnitOfWork()
        {
            _context = new NORTHWNDEntities();
        }
        #endregion

        #region Repository
        public CategoriesRepository CategoriesRepository
        {
            get
            {
                if (_categoriesRepository == null)
                    _categoriesRepository = new CategoriesRepository(_context);

                return _categoriesRepository;
            }
        }

        public ProductsRepository ProductsRepository
        {
            get
            {
                if (_productsRepository == null)
                    _productsRepository = new ProductsRepository(_context);

                return _productsRepository;
            }
        }

        public EmployeesRepository EmployeesRepository
        {
            get
            {
                if (_employeesRepository == null)
                    _employeesRepository = new EmployeesRepository(_context);

                return _employeesRepository;
            }
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

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}
