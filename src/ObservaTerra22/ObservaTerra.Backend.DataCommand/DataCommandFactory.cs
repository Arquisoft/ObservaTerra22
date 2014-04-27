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
        public static IObservationCommand GetObservationCommand(User user)
        {
            return new ObservationCommand(user);
        }
    }
}
