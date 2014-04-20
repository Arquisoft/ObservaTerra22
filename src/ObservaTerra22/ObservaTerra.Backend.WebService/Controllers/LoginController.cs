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
    public class LoginController : ApiController
    {
        public string Get(string user, string pass)
        {
            try
            {
                //Login, store parameters and retrieve token to return. Depends on SessionManager
                return "TOKEN";
            }
            catch (Exception)
            {
                //Catch an exception when user specifies incorrect data
                return "ERROR";
            }

        }
    }
}
