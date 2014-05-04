using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Exceptions
{
    class RoleNameAlreadyInUseException : Exception
    {
        public RoleNameAlreadyInUseException() {}

        public RoleNameAlreadyInUseException(string message)
            : base(message){}

        public RoleNameAlreadyInUseException(string message, Exception inner)
            : base(message, inner){}
    }
}
