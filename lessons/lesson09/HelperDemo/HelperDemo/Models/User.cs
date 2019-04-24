using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelperDemo.Models
{
    public enum UserGender
    {
        Male, Female, Unknown
    }

    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name="Возраст")]
        public int Age { get; set; }
        [Display(Name="Пол")]
        public UserGender Gender { get; set; }
    }
}