using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Exceptions
{
    public class TokenNotFoundException : Exception
    {
        public TokenNotFoundException() {}

        public TokenNotFoundException(string message)
            : base(message){}

        public TokenNotFoundException(string message, Exception inner)
            : base(message, inner){}
    }
}
