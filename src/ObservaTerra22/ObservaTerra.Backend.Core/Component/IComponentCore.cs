using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Core
{
    public interface IComponentCore
    {
        IComponent GetComponent(int id);

        IEnumerable<IComponent> FindComponents(string partialname);
    }
}
