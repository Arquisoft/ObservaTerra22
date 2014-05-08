using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataCommand
{
    public interface IIndicatorCommand
    {
        User User { get; }
        void AddIndicator(Indicator indicator);
    }
}
