using ObservaTerra.DomainModel;
using ObservaTerra.Web.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ObservaTerra.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            UserWeb uw = Session["User"] as UserWeb;
            if (uw != null)
                filterContext.HttpContext.User = uw;
            base.OnAuthorization(filterContext);
        }

        protected UserWeb User
        {
            get
            {
                if (!base.User.Identity.IsAuthenticated)
                    return new UserWeb("guest", "0", new List<Role>());
                return (UserWeb)base.User;
            }
        }
    }
}
