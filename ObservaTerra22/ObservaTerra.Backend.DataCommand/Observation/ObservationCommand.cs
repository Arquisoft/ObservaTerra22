using ObservaTerra.Backend.AccessCore;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataCommand
{
    class ObservationCommand : IObservationCommand
    {
        public User User { get; private set; }

        public void AddObservation(Observation observation)
        {
            IObservationAccess access = AccessCoreFactory.GetObservationAccess(User);
            access.AddObservation(observation);
        }

        public ObservationCommand(DomainModel.User user)
        {
            this.User = user;
        }

    }
}
