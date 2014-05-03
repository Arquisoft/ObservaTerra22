using ObservaTerra.Backend.AccessCore;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataQuery
{
    class ComponentQuery : IComponentQuery
    {
        public User User { get; private set; }

        public ComponentQuery(DomainModel.User user)
        {
            this.User = user;
        }

        public IComponent GetComponent(int id)
        {
            IComponentAccess access = AccessCoreFactory.GetComponentAccess(User);
            return access.GetComponent(id);
        }

        public IEnumerable<IComponent> FindComponents(string partialname)
        {
            IComponentAccess access = AccessCoreFactory.GetComponentAccess(User);
            return access.FindComponents(partialname);
        }

        public void Add(IComponent component)
        {
            IComponentAccess access = AccessCoreFactory.GetComponentAccess(User);
            access.Add(component);
        }
    }
}
