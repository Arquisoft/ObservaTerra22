using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataAcquisition
{
    [Serializable]
    public class DataSources
    {
        public List<string> Sources { get; set; }
        public DataSources()
        {
            Sources = new List<string>();
        }

        public void Add(string u)
        {
            if (!Sources.Contains(u))
                Sources.Add(u);
        }
        public void Remove(string u)
        {
            Sources.Remove(u);
        }
    }
}
