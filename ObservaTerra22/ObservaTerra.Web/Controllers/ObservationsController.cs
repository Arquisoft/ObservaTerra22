﻿using ObservaTerra.Backend.WebService;
using ObservaTerra.DomainModel;
using ObservaTerra.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
    public class ObservationsController : BaseController
    {
        public ViewResult Index(string partialname = "")
        {
            var result = Factory.GetObservationController().Get(User.Token, "");

            return View(result);
        }

        public ViewResult Details(int id)
        {
            var result = Factory.GetObservationController().Get(User.Token, id);

            return View(result);
        }

        #region · Create ·
        [Authorize]
        public ActionResult Create()
        {
            return View(new ObservationModel() { Components = GetComponentsSelectListItem() });
        }


        [HttpPost]
        public ActionResult Create(ObservationModel observation)
        {
            if (ModelState.IsValid)
            {
                Factory.GetObservationController().Post(User.Token, GetObservation(observation));
                return RedirectToAction("Index");
            }

            return View(observation);
        }

        private Observation GetObservation(ObservationModel observationmodel)
        {
            var result = new Observation() { Name = observationmodel.Name, IComponents = new List<IComponent>() };
            var components = Factory.GetComponentController().Get(User.Token, "");

            foreach (var item in components.Where(c => observationmodel.ComponentsSelected.Any(sl => sl == c.Id.ToString())))
            {
                result.IComponents.Add(item);
            }

            result.CreationDate = TimeSpan.FromMilliseconds(DateTime.Now.Millisecond);

            return result;
        }

        private IList<SelectListItem> GetComponentsSelectListItem()
        {
            var components = Factory.GetComponentController().Get(User.Token, "");
            return components.Aggregate<IComponent, IList<SelectListItem>>(new List<SelectListItem>(), (lista, component) =>
            {
                lista.Add(GetSelectListItem(component));
                return lista;
            });
        }

        private SelectListItem GetSelectListItem(IComponent component)
        {
            return new SelectListItem() { Text = component.Name, Value = component.Id.ToString() };
        }
        #endregion
    }
}
