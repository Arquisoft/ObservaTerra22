using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
    public class IndicatorsController : Controller
    {
        //
        // GET: /Indicators/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Indicators/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Indicators/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Indicators/Create

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

        //
        // GET: /Indicators/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Indicators/Edit/5

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

        //
        // GET: /Indicators/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Indicators/Delete/5

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
