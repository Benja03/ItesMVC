using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//using System.Data.Entity;
//using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class DocenteModels
    {
        [Display(Name = "LEGAJO")]
        public int legajo { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Por favor, ingrese un nombre"), MaxLength(30)]
        [Display(Name = "NOMBRE")]
        public string Nombre { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Por favor, ingrese un apellido"), MaxLength(30)]
        [Display(Name = "APELIDO")]
        public string Apellido { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "MATERIA")]
        public string Materia { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [Display(Name ="EMAIL")]
        public string Mail { get; set; }
    }
}