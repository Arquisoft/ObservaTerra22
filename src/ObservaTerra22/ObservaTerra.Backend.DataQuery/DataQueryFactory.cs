using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataQuery
{
    public class DataQueryFactory
    {
        public static IObservationQuery GetObservationQueries()
        {
            return new ObservationQuery();
        }
    }
}
