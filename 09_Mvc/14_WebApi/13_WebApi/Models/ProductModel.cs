using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _13_WebApi.Models
{
    public class ProductModel
    {
        [Range(1, 1000, ErrorMessage = "Id değeri 1 ile 1000 arasında olmalıdır!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "İsim alanı boş bırakılamaz!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fiyat alanı boş bırakılamaz!")]
        public double Price { get; set; }

        [Required(ErrorMessage = "PersonelId alanı boş bırakılamaz!")]
        public int PersonelId { get; set; }
    }
}