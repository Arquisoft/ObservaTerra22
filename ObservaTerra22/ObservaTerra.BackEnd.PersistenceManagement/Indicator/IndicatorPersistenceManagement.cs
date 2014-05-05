using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.PersistenceManagement
{
    class IndicatorPersistenceManagement : IIndicatorPersistenceManagement
    {
        public Indicator GetIndicator(int id)
        {
            Indicator result = null;

            using (var container = new DomainModelContainer())
            {
                result = container.Indicators.Single(i => i.Id == id);
                container.Entry(result).Reference(i => i.Area).Load();
                container.Entry(result).Collection(i => i.Observations).Load();
            }

            return result;   
        }

        public IEnumerable<Indicator> FindIndicators(string partialname)
        {
            ICollection<Indicator> result = new List<Indicator>();

            using (var container = new DomainModelContainer())
            {
                foreach (var indicator in container.Indicators.Where(i => i.Name.Contains(partialname)))
                {
                    container.Entry(indicator).Reference(i => i.Area).Load();
                    result.Add(indicator);
                }
            }

            return result;
        }

        public void Add(Indicator indicator)
        {
            using (var container = new DomainModelContainer())
            {
                container.Indicators.Add(indicator);
                container.SaveChanges();
            }
        }
    }
}
