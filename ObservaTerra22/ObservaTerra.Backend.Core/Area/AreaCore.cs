using ObservaTerra.Backend.PersistenceManagement;
using ObservaTerra.DomainModel;
using System.Collections.Generic;

namespace ObservaTerra.Core
{
    class AreaCore : IAreaCore
    {
        public Area GetArea(int id)
        {
            IAreaPersistenceManagement persistence = PersistenceManagementFactory.GetAreaPersistenceManagement();
            return persistence.GetArea(id);
        }

        public IEnumerable<Area> FindAreas(string partialname)
        {
            IAreaPersistenceManagement persistence = PersistenceManagementFactory.GetAreaPersistenceManagement();
            return persistence.FindAreas(partialname);
        }


        public void Add(Area area)
        {
            IAreaPersistenceManagement persistence = PersistenceManagementFactory.GetAreaPersistenceManagement();
            persistence.Add(area);
        }
    }
}
