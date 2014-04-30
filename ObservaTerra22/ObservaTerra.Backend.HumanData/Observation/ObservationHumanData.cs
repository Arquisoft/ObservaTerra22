using ObservaTerra.Backend.DataCommand;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.HumanData
{
    class ObservationHumanData : IObservationHumanData
    {
        public User User { get; private set; }

        public ObservationHumanData(DomainModel.User user)
        {
            this.User = user;
        }

        public void AddObservation(Observation observation)
        {
            IObservationCommand command = DataCommandFactory.GetObservationCommand(User);
            command.AddObservation(observation);
        }
    }
}
