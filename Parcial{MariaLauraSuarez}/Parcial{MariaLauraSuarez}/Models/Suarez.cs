using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial_MariaLauraSuarez_.Models
{
    public class Suarez
    {
        [Key]
        [Display(Name ="NOMBRE DEL PAIS")]
        public string name { get; set; }

        [Required]
        [Display(Name ="ABREVIACION DEL PAIS")]
        public string alpha3code { get; set; }

        [Display(Name ="REGION")]
        public string region { get; set; }

        [Display(Name ="AREA")]
        public int area { get; set; }

        [Display(Name ="CALLING CODES")]
        public int callingcodes { get; set; }

        [Display(Name ="LENGUAJE")]
        public string languages { get; set; }

        [Display(Name ="URL")]
        [Url]
        public int MyProperty { get; set; }
    }
}