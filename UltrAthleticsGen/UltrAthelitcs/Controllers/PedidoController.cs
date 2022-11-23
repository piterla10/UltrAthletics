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
    public class PedidoController : BasicController
    {
        // GET: Pedido
        public ActionResult Index()
        {
            SessionInitialize();
            PedidoCAD pedCAD = new PedidoCAD(session);
            PedidoCEN pedCEN = new PedidoCEN(pedCAD);

            IList<PedidoEN> listEN = pedCEN.DamePedidoTodos(0, 10);
            IEnumerable<PedidoViewModel> listViewModel = new PedidoAssembler().ConvertListENToModel(listEN).ToList();
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
