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
    public class LoggedInUser : User
    {
        /// <summary>
        /// The token attribute and property represent the token generated at the system so that the user, whether logged in or just a guest, can interact with the system
        /// and ask for some system services.
        /// </summary>
        private string token;
        public string Token
        {
            get { return this.token; }
        }

        public LoggedInUser(User user, string token)
        {
            if (String.IsNullOrWhiteSpace(token))
            {
                throw new ArgumentException("Cannot assign a null or empty token");
            }
            base.Id = user.Id;
            base.Name = user.Name;
            this.token = token;
            base.Username = user.Username;
            base.Password = user.Password;
        }
    }
}