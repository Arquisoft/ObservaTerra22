using ObservaTerra.DomainModel;
using System.Collections.Generic;

namespace ObservaTerra.Core
{
    public interface IAreaCore
    {
        Area GetArea(int id);

        IEnumerable<Area> FindAreas(string partialname);

        void Add(Area area);
    }
}
