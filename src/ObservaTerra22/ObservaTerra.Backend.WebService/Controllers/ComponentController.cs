﻿using ObservaTerra.Backend.DataQuery;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ObservaTerra.Backend.WebService.Controllers
{
    public class IndicatorController : ApiControllerLogin
    {

        public IComponent Get(string token, int id)
        {
            User user = GetUserByToken(token);
            IComponentQuery query = DataQueryFactory.GetComponentQuery(user);
            return query.GetComponent(id);
        }

        public IEnumerable<IComponent> Get(string token, string partialname)
        {
            User user = GetUserByToken(token);
            IComponentQuery query = DataQueryFactory.GetComponentQuery(user);
            return query.FindComponents(partialname);
        }
    }
}