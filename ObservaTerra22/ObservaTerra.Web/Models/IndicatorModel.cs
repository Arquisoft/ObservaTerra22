using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ObservaTerra.Web.Models
{
    public class IndicatorModel
    {
        public string Name { get; set; }
        public IEnumerable<SelectListItem> Areas { get; set; }
        public string SelectedArea { get; set; }
        public IEnumerable<SelectListItem> Observations { get; set; }
        public IList<string> SelectedObservations { get; set; }
        public DateTime Instant
        {
            get
            {
                return new DateTime();
            }
        }
    }
}