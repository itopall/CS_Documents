using _13_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_WebApi.Data
{
    public static class PersonelData
    {
        public static List<PersonelModel> Personels = new List<PersonelModel>
        {
            new PersonelModel { Id = 1, NameSurname = "Bahadır Soğucaklı", Title = "Dba", Username = "bhadir.sogucakli", Password = "1234" },
            new PersonelModel { Id = 2, NameSurname = "İlker Topal", Title = "Yazılım Uzmanı", Username="ilker.topal", Password = "4321" },
            new PersonelModel { Id = 3, NameSurname = "Utku Koçlar", Title = "Öğrenci", Username="utku.koclar", Password = "qqqq" },
        };
    }
}