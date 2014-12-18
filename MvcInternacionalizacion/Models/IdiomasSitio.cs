using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace MvcInternacionalizacion.Models
{
    public class IdiomasSitio
    {
        public static List<Idioma> IdiomasDisponibles
            = new List<Idioma>()
            {
                new Idioma() {NombreIdioma = "Español", NombreCultura = "es"},
              new Idioma() {NombreIdioma = "Ingles", NombreCultura = "en"},
              

            };

        public static String GetDefaultIdioma()
        {
            return IdiomasDisponibles[0].NombreCultura;
        }

        public static bool IsIdiomaDisponible(String lang)
        {

            var esta = IdiomasDisponibles.Any(o => o.NombreCultura == lang);
            return esta;
        }

        public void SetIdioma(String lang)
        {
            if (!IsIdiomaDisponible(lang))
            {
                lang = GetDefaultIdioma();
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

            HttpCookie coc=new HttpCookie("lang",lang);
            coc.Expires = DateTime.Now.AddDays(7);
            HttpContext.Current.Response.Cookies.Add(coc);
        }
    }

    public class Idioma
    {
        public String NombreIdioma { get; set; }
        public String NombreCultura { get; set; }
    
    }
}