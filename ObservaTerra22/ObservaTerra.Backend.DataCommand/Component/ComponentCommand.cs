﻿using ObservaTerra.Backend.AccessCore;
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
        public User User { get; private set; }

        public ComponentCommand(User user)
        {
            this.User = user;
        }

        public void AddComponents(IList<IComponent> components){
            IComponentAccess access = AccessCoreFactory.GetComponentAccess();
            Parallel.ForEach(components, c => access.Add(c));
        }
    }
}
