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
    public abstract class ApiControllerLogin : ApiController
    {
        public ISessionProcessorServices Session { get; set; } //Another trap...

        private User DefaultUser
        {
            get
            {
                return new User();
            }
        }

        protected User GetUserByToken(string token)
        {
            if (token == null || token == "0")
                return DefaultUser;
            return Session.ActiveTokens[token];
        }
    }
}
