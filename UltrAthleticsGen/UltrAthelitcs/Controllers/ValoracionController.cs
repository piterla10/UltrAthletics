using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UltrAthelitcs.Models;
using UltrAthelitcs.Assemblers;
using UltrAthleticsGenNHibernate.CAD.UltrAthletics;
using UltrAthleticsGenNHibernate.CEN.UltrAthletics;
using UltrAthleticsGenNHibernate.EN.UltrAthletics;

namespace UltrAthelitcs.Controllers
{
    public class ValoracionController : BasicController
    {
        // GET: Valoracion
        public ActionResult Index()
        {
            SessionInitialize();
            ValoracionCAD valCAD = new ValoracionCAD(session);
            ValoracionCEN valCEN = new ValoracionCEN(valCAD);

            IList<ValoracionEN> listEn = valCEN.DameValoracionTodos(0, -1);
            IEnumerable<ValoracionViewModel> listViewModel = new ValoracionAssembler().ConvertListENToModel(listEn).ToList();
            SessionClose();
            return View(listViewModel);
        }

        // GET: Valoracion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Valoracion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Valoracion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Valoracion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Valoracion/Edit/5
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

        // GET: Valoracion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Valoracion/Delete/5
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
