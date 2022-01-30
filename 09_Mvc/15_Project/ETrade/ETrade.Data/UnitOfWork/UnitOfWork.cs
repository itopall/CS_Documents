using ETrade.Data.Context;
using ETrade.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        #region Variable
        private readonly ETradeEntities _context;

        private MemberRepository _memberRepository = null;
        private EmployeeRepository _employeeRepository = null;
        private EmployeeTypeRepository _employeeTypeRepository = null;
        private CategoryRepository _categoryRepository = null;
        private ProductRepository _productRepository = null;
        private SupplierRepository _supplierRepository = null;
        private PurchaseOrderRepository _purchaseOrderRepository = null;
        private PurchaseOrderDetailRepository _purchaseOrderDetailRepository = null;
        private ProductImageRepository _productImageRepository = null;
        private BasketRepository _basketRepository = null;
        private BasketDetailRepository _basketDetailRepository = null;
        #endregion

        #region Ctor
        public UnitOfWork()
        {
            _context = new ETradeEntities();
        }
        #endregion

        #region Repository
        public MemberRepository MemberRepository
        {
            get
            {
                if (_memberRepository == null)
                    _memberRepository = new MemberRepository(_context);

                return _memberRepository;
            }
        }
        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_context);

                return _employeeRepository;
            }
        }
        public EmployeeTypeRepository EmployeeTypeRepository
        {
            get
            {
                if (_employeeTypeRepository == null)
                    _employeeTypeRepository = new EmployeeTypeRepository(_context);

                return _employeeTypeRepository;
            }
        }
        public CategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new CategoryRepository(_context);

                return _categoryRepository;
            }
        }
        public ProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(_context);

                return _productRepository;
            }
        }
        public SupplierRepository SupplierRepository
        {
            get
            {
                if (_supplierRepository == null)
                    _supplierRepository = new SupplierRepository(_context);

                return _supplierRepository;
            }
        }
        public PurchaseOrderRepository PurchaseOrderRepository
        {
            get
            {
                if (_purchaseOrderRepository == null)
                    _purchaseOrderRepository = new PurchaseOrderRepository(_context);

                return _purchaseOrderRepository;
            }
        }
        public PurchaseOrderDetailRepository PurchaseOrderDetailRepository
        {
            get
            {
                if (_purchaseOrderDetailRepository == null)
                    _purchaseOrderDetailRepository = new PurchaseOrderDetailRepository(_context);

                return _purchaseOrderDetailRepository;
            }
        }
        public ProductImageRepository ProductImageRepository
        {
            get
            {
                if (_productImageRepository == null)
                    _productImageRepository = new ProductImageRepository(_context);

                return _productImageRepository;
            }
        }
        public BasketRepository BasketRepository
        {
            get
            {
                if (_basketRepository == null)
                    _basketRepository = new BasketRepository(_context);

                return _basketRepository;
            }
        }
        public BasketDetailRepository BasketDetailRepository
        {
            get
            {
                if (_basketDetailRepository == null)
                    _basketDetailRepository = new BasketDetailRepository(_context);

                return _basketDetailRepository;
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
