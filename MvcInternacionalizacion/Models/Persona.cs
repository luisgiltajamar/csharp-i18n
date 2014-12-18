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
     [Required(ErrorMessageResourceType = typeof(Resource),
       ErrorMessageResourceName = "frmErrNombreRequerido"
            )]
        [Display(ResourceType = typeof(Resource),
            Name = "frmNombre")]
        public String Nombre { get; set; }
        
       [Range(18,65,
           ErrorMessageResourceType = typeof(Resource),
           ErrorMessageResourceName ="frmErrEdadMinima" )]
       [Display(ResourceType = typeof(Resource),
          Name = "frmEdad")]
        public int Edad { get; set; }
    }
}