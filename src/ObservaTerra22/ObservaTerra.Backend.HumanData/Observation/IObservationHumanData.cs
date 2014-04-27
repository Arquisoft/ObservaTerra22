using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.HumanData
{
    public interface IObservationHumanData
    {
        User User { get; }

        void AddObservation(Observation observation);
    }
}
