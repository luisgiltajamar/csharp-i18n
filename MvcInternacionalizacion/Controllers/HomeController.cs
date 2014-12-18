using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcInternacionalizacion.Models;

namespace MvcInternacionalizacion.Controllers
{
    public class HomeController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                var coc = Request.Cookies["lang"];

                if (coc != null)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(coc.Value);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(coc.Value);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            base.OnActionExecuting(filterContext);
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(new Persona());
        }
        [HttpPost]
        public ActionResult Index(Persona p)
        {
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Idioma(String idi)
        {
            var id = new IdiomasSitio();
            id.SetIdioma(idi);
            return Json("OK");
        }
    }
}