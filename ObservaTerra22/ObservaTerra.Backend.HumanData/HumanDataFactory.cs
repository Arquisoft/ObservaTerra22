using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.HumanData
{
    public static class HumanDataFactory
    {
        public static IObservationHumanData GetObservationHumanData(User user)
        {
            return new ObservationHumanData(user);
        }
    }
}
