using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataQuery
{
    public class DataQueryFactory
    {
        public static IObservationQuery GetObservationQueries(User user)
        {
            return new ObservationQuery(user);
        }

        public static IIndicatorQuery GetIndicatorQuery(User user)
        {
            return new IndicatorQuery(user);
        }

        public static IComponentQuery GetComponentQuery(User user)
        {
            return new ComponentQuery(user);
        }
    }
}
