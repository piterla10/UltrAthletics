using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UltrAthelitcs.Assemblers;
using UltrAthelitcs.Models;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Controllers
{
<<<<<<< Updated upstream:UltrAthleticsGen/UltrAthelitcs/Controllers/ProductoController.cs
    public class ProductoController : BasicController
=======
    public class PedidoController : BasicController
>>>>>>> Stashed changes:UltrAthleticsGen/UltrAthelitcs/Controllers/PedidoController.cs
    {
        // GET: Pedido
        public ActionResult Index()
        {
<<<<<<< Updated upstream:UltrAthleticsGen/UltrAthelitcs/Controllers/ProductoController.cs

            SessionInitialize();
            ProductoCAD proCAD = new ProductoCAD(session);
            ProductoCEN proCEN = new ProductoCEN(proCAD);

            IList<ProductoEN> listEn = proCEN.DameProductoTodos(0, -1);
            IEnumerable<ProductoViewModel> listViewModel = new ProductoAssembler().ConvertListENToModel(listEn).ToList();
=======
            SessionInitialize();
            PedidoCAD pedCAD = new PedidoCAD(session);
            PedidoCEN pedCEN = new PedidoCEN(pedCAD);

            IList<PedidoEN> listEN = pedCEN.DamePedidoTodos(0, 10);
            IEnumerable<PedidoViewModel> listViewModel = new PedidoAssembler().ConvertListENToModel(listEN).ToList();
>>>>>>> Stashed changes:UltrAthleticsGen/UltrAthelitcs/Controllers/PedidoController.cs
            SessionClose();

            return View(listViewModel);
        }

        // GET: Pedido/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pedido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pedido/Create
        [HttpPost]
        public ActionResult Create(PedidoViewModel ped)
        {
            try
            {
                SessionInitialize();
                PedidoCAD pedCAD = new PedidoCAD(session);
                PedidoCEN pedCEN = new PedidoCEN(pedCAD);
                pedCEN.CrearPedido(ped.Estado,ped.Usuario.Nombre);
                SessionClose();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pedido/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pedido/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
