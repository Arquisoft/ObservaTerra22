using ObservaTerra.DomainModel;
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
                if(result is GraphComponent)
                {
                    GraphComponent r = (GraphComponent)result;
                    r.Values.Select(p => p.Id);
                }
            }

            return result;   
        }

        public IEnumerable<IComponent> FindComponents(string partialname)
        {
            ICollection<IComponent> result = new List<IComponent>();

            using (var container = new DomainModelContainer())
            {
                //foreach (var component in container.IComponents.Where(c => c.Observation.Indicator.Name == partialname))
                foreach (var component in container.IComponents)    // TODO, this do not search for any.               
                    result.Add(component);
            }

            return result;   
        }


        public void Add(IComponent component)
        {
            using (var container = new DomainModelContainer())
            {
                container.IComponents.Add(component);
                container.SaveChanges();
            }
        }
    }
}
