using ObservaTerra.Backend.PersistenceManagement;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
