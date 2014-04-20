using ObservaTerra.Backend.DataQuery;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ObservaTerra.Backend.WebService.Controllers
{
    public abstract class ApiControllerLogin : ApiController
    {
        private User DefaultUser
        {
            get
            {
                return new User();
            }
        }

        protected User GetUserByToken(string token)
        {
            //We need to retrieve from SessionManager logged users.
            return DefaultUser;
        }
    }
}
