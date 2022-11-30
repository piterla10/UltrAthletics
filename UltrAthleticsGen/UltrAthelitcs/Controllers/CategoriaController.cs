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
    public class CategoriaController : BasicController
    {
        // GET: Categoria
        public ActionResult Index()
        {
            SessionInitialize();
            CategoriaCAD catCAD = new CategoriaCAD(session);
            CategoriaCEN catCEN = new CategoriaCEN(catCAD);

            IList<CategoriaEN> listEn = catCEN.DameCategoriaTodos(0, -1);
            IEnumerable<CategoriaViewModel> listViewModel = new CategoriaAssembler().ConvertListENToModel(listEn).ToList();
            SessionClose();

            return View(listViewModel);
            return View();
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(CategoriaViewModel cat)
        {
            try
            {
                // TODO: Add insert logic here
                CategoriaCEN categoriaCEN = new CategoriaCEN();
                categoriaCEN.CrearCategoria(cat.Nombre, cat.Descripcion);
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categoria/Edit/5
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

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categoria/Delete/5
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
