using ObservaTerra.DomainModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
    public class ComponentsController : Controller
    {
        public ViewResult Index()
        {
            User user = Util.GetUser(User);
            var result = new ObservaTerra.Backend.WebService.Controllers.ComponentController().Get(null, "");
            return View(result);
        }

       /* // GET api/components/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/components
        public void Post(string value)
        {
        }

        // PUT api/components/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/components/5
        public void Delete(int id)
        {
        }*/
    }
}
