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
        public ISessionProcessorServices Session { get; set; } //Trap

        public LoggedInUser Get(string user, string pass)
        {
            try
            {
                return Session.Login(user, pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
