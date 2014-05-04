using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataQuery
{
    public interface IAreaQuery
    {
        User User { get; }

        Area GetArea(int id);

        IEnumerable<Area> FindAreas(string partialname);

        void Add(Area area);
    }
}
