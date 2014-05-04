using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ObservaTerra.Web.Models
{
    public class ObservationModel
    {
        public string Name { get; set; }
        public IList<SelectListItem> Components { get; set; }
        public IList<string> ComponentsSelected { get; set; }
    }
}