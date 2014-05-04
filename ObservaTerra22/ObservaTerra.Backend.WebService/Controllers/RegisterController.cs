using ObservaTerra.Backend.DataQuery;
using ObservaTerra.DomainModel;
using ObservaTerra.SessionManager.Managers;
using ObservaTerra.SessionManager.Managers.AdminModule;
using ObservaTerra.SessionManager.Managers.SessionProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ObservaTerra.Backend.WebService.Controllers
{
    public class RegisterController : ApiController
    {
        public void Post(string username, string password)
        {
            IAdminModuleServices session = ManagersFactory.GetAdminModuleServices();
            User user = new User() { Username = username, Name = username, Password = password };
            session.RegisterUser(user);            
        }
    }
}
