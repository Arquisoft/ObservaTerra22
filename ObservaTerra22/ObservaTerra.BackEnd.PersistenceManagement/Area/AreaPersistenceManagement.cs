using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.PersistenceManagement
{
    class AreaPersistenceManagement : IAreaPersistenceManagement
    {
        public Area GetArea(int id)
        {
            Area result = null;

            using (var container = new DomainModelContainer())
            {
                result = container.Areas.Single(c => c.Id == id);
            }

            return result;   
        }

        public IEnumerable<Area> FindAreas(string partialname)
        {
            ICollection<Area> result = new List<Area>();

            using (var container = new DomainModelContainer())
            {
                //foreach (var component in container.IComponents.Where(c => c.Observation.Indicator.Name == partialname))
                foreach (var area in container.Areas)    // TODO, this do not search for any.               
                    result.Add(area);
            }

            return result;   
        }


        public void Add(Area area)
        {
            using (var container = new DomainModelContainer())
            {
                container.Areas.Add(area);
                container.SaveChanges();
            }
        }
    }
}
