using System;
using System.Collections.Generic;
using ObservaTerra.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Managers.SessionProcessor
{
    /// <summary>
    /// This class represent instances of logged in users returned by the SessionProcessor once the login process has been completed successfully
    /// </summary>
    public class LoggedInUser
    {
        /// <summary>
        /// The token attribute and property represent the token generated at the system so that the user, whether logged in or just a guest, can interact with the system
        /// and ask for some system services.
        /// </summary>
        private string token;
        public string Token { 
            get { return this.token; }
        }

        /// <summary>
        /// The username is the identifier of the user in the system, the identifier he/she logs in with.
        /// </summary>
        private string username;
        public string Username { 
            get { return this.username; }
        }

        /// <summary>
        /// The name attribute and property represent the real name of the person with this user account.
        /// </summary>
        private string name;
        public string Name { 
            get { return this.name; }
        }

        /// <summary>
        /// The roles attribute and property represents the different roles the user has in the system (activist, journalist, organization member, etc)
        /// </summary>
        private ICollection<Role> roles;
        public ICollection<Role> Roles
        { 
            get { return this.roles; }
        }

        public LoggedInUser(string token, string username, string name, ICollection<Role> roles)
        {
            if (String.IsNullOrWhiteSpace(token))
            {
                throw new ArgumentException("Cannot assign a null or empty token");
            }
            this.token = token;
            this.username = username;
            this.name = name;
            this.roles = roles;
        }
    }
}
