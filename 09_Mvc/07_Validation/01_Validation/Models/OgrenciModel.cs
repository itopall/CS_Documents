using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _01_Validation.Models
{
    //Fluent Validation, gelişmiş bir validasyon yöntemidir.
    public class OgrenciModel
    {
        [Required(ErrorMessage = "Lütfen bir No giriniz!")]
        [Range(1,1000, ErrorMessage = "Minimum 1 Maksimum 1000 olarak değer girebilirsiniz!")]
        public int No { get; set; }

        [Required(ErrorMessage = "Lütfen bir AdSoyad giriniz!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "En az 5 en fazla 60 karakter girebilirsiniz!")]
        public string AdSoyad { get; set; }

        [Required(ErrorMessage = "Lütfen bir DogumTarihi giriniz!")]
        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        [Required(ErrorMessage = "Lütfen bir EMail giriniz!")]
        [EmailAddress(ErrorMessage = "Email adresi geçersiz")]
        public string EMail { get; set; }
    }
}