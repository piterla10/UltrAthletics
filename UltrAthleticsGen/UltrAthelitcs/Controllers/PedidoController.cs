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
    [Authorize]
    public class PedidoController : BasicController
    {
        // GET: Pedido
        public ActionResult Index()
        {
            SessionInitialize();
            PedidoCAD pedCAD = new PedidoCAD(session);
            PedidoCEN pedCEN = new PedidoCEN(pedCAD);
            LineaPedidoCAD linCAD = new LineaPedidoCAD(session);
            LineaPedidoCEN linCEN = new LineaPedidoCEN(linCAD);

            IList<PedidoEN> listEN = pedCEN.DamePedidoTodos(0, 10);
            IEnumerable<PedidoViewModel> listViewModel = new PedidoAssembler().ConvertListENToModel(listEN).ToList();

            var i = 0;
            foreach(var pedido in listEN)
            {
                IList<LineaPedidoEN> aux = pedido.LineaPedido;
                List<LineaPedidoEN> linEN = new List<LineaPedidoEN>();

                var j = 0;
                foreach (var linea in aux)
                {
                    LineaPedidoEN auxL = new LineaPedidoEN(linea);
                    ViewData["LineaPedido" + i + "Producto" + j] = auxL.Producto;
                    j++;
                    linEN.Add(auxL);
                }
                ViewData["LineaPedido" + i] = linEN;
                i++;
            }
            /* añadir a index
              @foreach (var producto in lineaPedido)
                {
                    <div class="producto">
                        <h4>@Html.DisplayFor(modelItem => producto.Producto.Nombre)</h4>
                        <img src="@Html.DisplayFor(modelItem => producto.Producto.Imagen)"
                        <p>@Html.DisplayFor(modelItem => producto.Producto.Precio)</p>
                    </div>
                }
             */
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
                pedCEN.CrearPedido(ped.Estado, "patata");
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
