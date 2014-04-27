﻿using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.PersistenceManagement
{
    class ComponentPersistenceManagement : IComponentPersistenceManagement
    {
        public IComponent GetComponent(int id)
        {
            IComponent result = null;

            using (var container = new DomainModelContainer())
            {
                result = container.IComponents.Single(c => c.Id == id);
            }

            return result;   
        }

        public IEnumerable<IComponent> FindComponents(string partialname)
        {
            IEnumerable<IComponent> result = null;

            using (var container = new DomainModelContainer())
            {
                result = container.IComponents.Where(c => c.Observation.Indicator.Name == partialname);
            }

            return result;   
        }
    }
}
