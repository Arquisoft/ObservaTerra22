using ObservaTerra.Core;
using ObservaTerra.DomainModel;
using System.Collections.Generic;

namespace ObservaTerra.Backend.AccessCore
{
    class ComponentAccess : IComponentAccess
    {
        public User User { get; private set; }

        public ComponentAccess(DomainModel.User user)
        {
            this.User = user;
        }

        public IComponent GetComponent(int id)
        {
            IComponentCore core = CoreFactory.GetComponentCore();
            return core.GetComponent(id);
        }

        public IEnumerable<IComponent> FindComponents(string partialname)
        {
            IComponentCore core = CoreFactory.GetComponentCore();
            return core.FindComponents(partialname);
        }
    }
}
