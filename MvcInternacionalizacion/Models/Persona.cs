using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcInternacionalizacion.Models
{
    public class Persona
    {
        [Required]
        [DisplayName("Nombre")]
        public String Nombre { get; set; }
        
       [Range(18,65)]
        [DisplayName("Edad")]
        public int Edad { get; set; }
    }
}