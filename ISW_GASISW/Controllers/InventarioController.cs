using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISW_GASISW.Models;

namespace ISW_GASISW.Controllers
{
    public class InventarioController : Controller
    {
        private gasiswEntities db = new gasiswEntities();

        //
        // GET: /Inventario/
        public ActionResult Index()
        {            
            List<inventario> Lista = db.inventario.ToList();
            return View(Lista);
        }

        public ActionResult IXC()
        {
            List<categoria_producto> Lista = db.categoria_producto.Where(p=>p.id != 2).ToList();
            return View(Lista);
        }

        public ActionResult InvCat(long id = 0)
        {
            List<inventario> Lista = db.inventario.Where(p => p.producto.categoria_producto.id == id).ToList();
            return View(Lista);
        }
    }
}
