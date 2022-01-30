using _01_AspNetCoreMvc_Giris.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_AspNetCoreMvc_Giris.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<CategoryModel>
            {
                new CategoryModel { Id = 1, Name= "Bilgisayar" },
                new CategoryModel { Id = 2, Name= "Elektronik" }
            };

            return View(categories);
        }
    }
}
