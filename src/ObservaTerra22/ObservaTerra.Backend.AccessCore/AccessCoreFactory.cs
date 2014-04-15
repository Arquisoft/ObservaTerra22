using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.AccessCore
{
    public class AccessCoreFactory
    {
        public static IObservationAccess GetObservationAccess()
        {
            return new ObservationAccess();
        }
    }
}
