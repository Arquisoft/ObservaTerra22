using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataCommand
{
    public static class DataCommandFactory
    {
        public static IAreaCommand GetAreaCommand(User user)
        {
            return new AreaCommand(user);
        }
        public static IComponentCommand GetComponentCommand(User user){
            return new ComponentCommand(user);
        }

        public static IIndicatorCommand GetIndicatorCommand(User user)
        {
            return new IndicatorCommand(user);
        }

        public static IObservationCommand GetObservationCommand(User user)
        {
            return new ObservationCommand(user);
        }
    }
}
