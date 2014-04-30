using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Exceptions
{
    public class UsernameAlreadyInUseException : Exception
    {
        public UsernameAlreadyInUseException() {}

        public UsernameAlreadyInUseException(string message)
            : base(message){}

        public UsernameAlreadyInUseException(string message, Exception inner)
            : base(message, inner){}
    }
}
