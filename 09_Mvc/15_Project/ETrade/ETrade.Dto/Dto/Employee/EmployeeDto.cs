using ETrade.Dto.Dto.EmployeeType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto.Dto.Employee
{
    public class EmployeeDto : BaseDto
    {
        [Required(ErrorMessage = "Lütfen bir Personel Tipi seçiniz!")]
        [Range(1, 10000000, ErrorMessage = "Minimum 1 Maksimum 10000000 olarak değer girebilirsiniz!")]
        [DisplayName("Personel Tipi")]
        public Nullable<int> EmployeeTypeId { get; set; }

        [DisplayName("Müdür")]
        public Nullable<int> ManagerEmployeeId { get; set; }

        [Required(ErrorMessage = "Lütfen bir İsim Soyisim giriniz!")]
        [DisplayName("İsim Soyisim")]
        public string Namesurname { get; set; }

        [Required(ErrorMessage = "Lütfen bir Kullanıcı Adı giriniz!")]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen bir Şifre giriniz!")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Ünvan")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen bir Email giriniz!")]
        [EmailAddress(ErrorMessage = "Email adresi geçersiz")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen bir Telefon giriniz!")]
        [DisplayName("Telefon")]
        public string Phone { get; set; }

        [DisplayName("Tanıdık Telefon")]
        public string RelatedPhone { get; set; }

        [Required(ErrorMessage = "Lütfen bir Adres giriniz!")]
        [DisplayName("Adres")]
        public string Address { get; set; }

        [DisplayName("Adres-2")]
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Lütfen bir Doğum Günü giriniz!")]
        [DataType(DataType.Date)]
        [DisplayName("Doğum Tarihi")]
        public Nullable<System.DateTime> BirthDate { get; set; }

        [DisplayName("Cinsiyet")]
        public bool Gender { get; set; }

        [DisplayName("Aktif Mi")]
        public bool IsActive { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Profil Fotoğrafı")]
        public string ImageUrl { get; set; }


        //For DropDownList
        public List<EmployeeTypeDto> EmployeeTypeList { get; set; }
        public List<EmployeeDto> EmployeeList { get; set; }
    }
}
