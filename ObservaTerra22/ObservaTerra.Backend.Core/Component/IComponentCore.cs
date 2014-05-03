using ObservaTerra.DomainModel;
using System.Collections.Generic;

namespace ObservaTerra.Core
{
    public interface IComponentCore
    {
        IComponent GetComponent(int id);

        IEnumerable<IComponent> FindComponents(string partialname);

        void Add(IComponent component);
    }
}
