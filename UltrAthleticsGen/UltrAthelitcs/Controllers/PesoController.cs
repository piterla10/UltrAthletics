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
    public class PesoController : BasicController
    {
        // GET: Peso
        public ActionResult Index()
        {
            SessionInitialize();
            PesoCAD pesoCAD = new PesoCAD(session);
            PesoCEN pesoCEN = new PesoCEN(pesoCAD);

            IList<PesoEN> listEn = pesoCEN.DamePesoTodos(0, -1);
            IEnumerable<PesoViewModel> listViewModel = new PesoAssembler().ConvertListENToModel(listEn).ToList();
            SessionClose();

            return View(listViewModel);
        }

        // GET: Peso/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Peso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peso/Create
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

        // GET: Peso/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Peso/Edit/5
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

        // GET: Peso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Peso/Delete/5
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
