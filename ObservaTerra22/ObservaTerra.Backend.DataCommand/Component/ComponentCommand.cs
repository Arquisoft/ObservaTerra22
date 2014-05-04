using ObservaTerra.Backend.AccessCore;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.Backend.DataCommand
{
    class ComponentCommand : IComponentCommand
    {
        public ComponentCommand() { }
        public void addComponents(List<IComponent> components){
            IComponentAccess access = AccessCoreFactory.GetComponentAccess();
            components.ForEach(x => access.Add(x));
        }
    }
}
