﻿using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ObservaTerra.Web.Models.Users
{
    public class UserWeb : IPrincipal
    {
        public IIdentity Identity { get; private set; }
        public string Token { get; private set; }

        private ICollection<Role> _roles;

        public UserWeb(string name, string token, ICollection<Role> roles)
        {
            Identity = new IdentityWeb(name);
            this.Token = token;
            this._roles = roles;
        }
        
        public bool IsInRole(string role)
        {
            return _roles.Any(r => r.Name == role);
        }
    }
}