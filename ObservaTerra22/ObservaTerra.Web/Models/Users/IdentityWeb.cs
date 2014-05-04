using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ObservaTerra.Web.Models.Users
{
    public class IdentityWeb : IIdentity
    {
        public IdentityWeb(string name)
        {
            this.Name = name;
        }
        
        public string AuthenticationType
        {
            get 
            {
                return "OB_1";
            }
        }

        public bool IsAuthenticated
        {
            get 
            {
                return Name != "guest";
            }
        }

        public string Name { get; private set; }
    }
}