using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingleResponsibility
{
    class UserBusiness
    {
        AddressBusiness _addressBusiness;
        public UserBusiness()
        {
            _addressBusiness = new AddressBusiness();
        }

        public void UpdateUser(string username, string address)
        {
            Console.WriteLine("Kullanıcı güncellendi...");

            _addressBusiness.AddAddress(address);
        }

        //Adres veritabanında farklı bir tabloda saklandığı için UserBusiness class'ının içerisinde olmamalıdır! Adrese özel yeni bir class açılarak bu operasyon oraya taşınmalıdır.
        //private bool AddAddress(string address)
        //{
        //    Console.WriteLine("Adres eklendi...");

        //    return true;
        //}
    }
}
