using ObservaTerra.Backend.PersistenceManagement;
using ObservaTerra.DomainModel;
using System.Collections.Generic;

namespace ObservaTerra.Core
{
    class ComponentCore : IComponentCore
    {
        public IComponent GetComponent(int id)
        {
            IComponentPersistenceManagement persistence = PersistenceManagementFactory.GetComponentPersistenceManagement();
            return persistence.GetComponent(id);
        }

        public IEnumerable<IComponent> FindComponents(string partialname)
        {
            IComponentPersistenceManagement persistence = PersistenceManagementFactory.GetComponentPersistenceManagement();
            return persistence.FindComponents(partialname);
        }


        public void Add(IComponent component)
        {
            IComponentPersistenceManagement persistence = PersistenceManagementFactory.GetComponentPersistenceManagement();
            persistence.Add(component);
        }
    }
}
