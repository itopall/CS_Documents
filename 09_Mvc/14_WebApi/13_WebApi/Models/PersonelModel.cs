using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _13_WebApi.Models
{
    public class PersonelModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="İsim Soyisim boş geçilemez!")]
        public string NameSurname { get; set; }

        public string Title { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }
    }
}