using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.AccessCore
{
    public interface IComponentAccess
    {
        User User { get; }

        IComponent GetComponent(int id);

        IEnumerable<IComponent> FindComponents(string partialname);
    }
}
