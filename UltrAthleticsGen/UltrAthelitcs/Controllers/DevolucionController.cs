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
    public class DevolucionController : BasicController
    {
        // GET: Devolucion
        public ActionResult Index()
        {
            SessionInitialize();
            DevolucionCAD valCAD = new DevolucionCAD(session);
            DevolucionCEN valCEN = new DevolucionCEN(valCAD);

            IList<DevolucionEN> listEn = valCEN.DameTodosDevolucion(0, -1);
            IEnumerable<DevolucionViewModel> listViewModel = new DevolucionAssembler().ConvertListENToModel(listEn).ToList();
            SessionClose();
            return View(listViewModel);
        }

        // GET: Devolucion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Devolucion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Devolucion/Create
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

        // GET: Devolucion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Devolucion/Edit/5
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

        // GET: Devolucion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Devolucion/Delete/5
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
