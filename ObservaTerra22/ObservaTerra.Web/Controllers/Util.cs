using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ObservaTerra.Web.Controllers
{
    public static class Util
    {
        public static User GetUser(IPrincipal user)
        {
            if (!user.Identity.IsAuthenticated)
                return null;
            return (User)user;
        }
    }
}