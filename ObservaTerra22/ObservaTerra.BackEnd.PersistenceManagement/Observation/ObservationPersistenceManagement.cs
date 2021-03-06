﻿using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.PersistenceManagement
{
    class ObservationPersistenceManagement : IObservationPersistenceManagement
    {
        public Observation GetObservation(int id)
        {
            Observation result = null;

            using (var container = new DomainModelContainer())
            {
                result = container.Observations.Single(o => o.Id == id);
                container.Entry(result).Reference(o => o.UserAuthor).Load();
                container.Entry(result).Collection(o => o.IComponents).Load();
            }

            return result;
        }


        public IEnumerable<Observation> FindObservations(string partialname)
        {
            ICollection<Observation> result = new List<Observation>();

            using (var container = new DomainModelContainer())
            {
                foreach (var observation in container.Observations)//.Where(o => o.Indicator.Name.Contains(partialname)))
                {
                    container.Entry(observation).Reference(o => o.UserAuthor).Load();
                    result.Add(observation);
                }
            }

            return result;
        }


        public void AddObservation(Observation observation)
        {
            using (var container = new DomainModelContainer())
            {
                container.Observations.Add(observation);
                container.SaveChanges();
            }
        }
    }
}
