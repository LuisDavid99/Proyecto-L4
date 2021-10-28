using Electronica.WebAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Electronica.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var cliente1 = new ClienteModel();
            cliente1.Id = 1;
            cliente1.Descripcion = "Luis";

            var cliente2 = new ClienteModel();
            cliente2.Id = 2;
            cliente2.Descripcion = "Jose";

            var cliente3 = new ClienteModel();
            cliente3.Id = 3;
            cliente3.Descripcion = "Juan";


            var listadeClientes = new List<ClienteModel>();
            listadeClientes.Add(cliente1);
            listadeClientes.Add(cliente2);
            listadeClientes.Add(cliente3);

            return View(listadeClientes);
        }
    }
}