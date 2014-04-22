using ObservaTerra.Backend.DataQuery;
using ObservaTerra.DomainModel;
using ObservaTerra.SessionManager.Managers;
using ObservaTerra.SessionManager.Managers.SessionProcessor;
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
                ISessionProcessorServices session = ManagersFactory.GetSessionProcessorServices();
                return session.Login(user, pass);
            }
            catch (Exception)
            {
                //Catch an exception when user specifies incorrect data
                return "ERROR";
            }

        }
    }
}
