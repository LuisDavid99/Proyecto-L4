using Electronica.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Electronica.Web.Controllers
{
    public class ComprarController : Controller
    {
        // GET: Comprar
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var ListadeProductos = productosBL.ObtenerProductosActivos();

            ViewBag.adminWebsiteUrl
                = ConfigurationManager.AppSettings["adminWebsiteUrl"];

            return View(ListadeProductos);
        }
    }
}