﻿using _01_Northwnd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StaticRepository.Repository
{
    public class CustomerRepository : RepositoryBase<Customers>, ICustomerRepository
    {
        public CustomerRepository()
        {
        }
    }

    interface ICustomerRepository
    {
    }
}
