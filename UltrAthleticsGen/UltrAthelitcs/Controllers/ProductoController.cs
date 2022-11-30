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
    public class ProductoController : BasicController
    {
        // GET: Producto
        public ActionResult Index()
        {

            SessionInitialize();
            ProductoCAD proCAD = new ProductoCAD(session);
            ProductoCEN proCEN = new ProductoCEN(proCAD);

            IList<ProductoEN> listEn = proCEN.DameProductoTodos(0, -1);
            IEnumerable<ProductoViewModel> listViewModel = new ProductoAssembler().ConvertListENToModel(listEn).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(ProductoViewModel pro)
        {
            try
            {
                ProductoCEN proCEN = new ProductoCEN();
                proCEN.CrearProducto(pro.nombre, pro.descripcion, pro.precio, pro.stock, pro.descuento, pro.imagenes);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
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

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
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
