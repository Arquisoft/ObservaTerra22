using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.AccessCore
{
    public class AccessCoreFactory
    {
        public static IObservationAccess GetObservationAccess(User user)
        {
            return new ObservationAccess(user);
        }

        public static IIndicatorAccess GetIndicatorAccess(User user)
        {
            return new IndicatorAccess(user);
        }

        public static IComponentAccess GetComponentAccess(User user)
        {
            return new ComponentAccess(user);
        }
    }
}
