using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using ObservaTerra.SessionManager;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Managers.SessionProcessor
{
    class SessionProcessorServices : ISessionProcessorServices
    {
        /// <summary>
        /// Table with all the active tokens representing active registered users
        /// </summary>
        public IDictionary<string, User> _activeTokens = new Dictionary<string, User>();

        public IDictionary<string, User> ActiveTokens
        {
            get
            { 
                return _activeTokens; 
            }
        }

        /// <summary>
        /// Token for guest users that are not registered in the system.
        /// </summary>
        private string guestToken = null;

        /// <summary>
        /// Performs the user login action and generates a token for that user
        /// </summary>
        /// <param name="username">The username of the user trying to login</param>
        /// <param name="password">The password of the user trying to login</param>
        /// <returns>The loggedinUser instance generated for the user</returns>
        public LoggedInUser Login(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("In order to login a user, the username and password cannot be null or empty");
            }
            User user = Persistence.PersistenceFactory.GetUserPersistenceManagement().FindByUsername(username);
            if (user != null && user.Password.Equals(HashingUtil.GenerateHash(password)))
            {
                string token = HashingUtil.GenerateHash(username, new Random().Next(500) + "");
                this._activeTokens[token] = user;
                //return new LoggedInUser(token: token, username: user.Username, name: user.Name, roles: user.Roles);
                return new LoggedInUser(user, token);
            }
            throw new Exceptions.EntityNotFoundException("No user with that username and password was found in the system");
        }

        /// <summary>
        /// Creates a default guest user token so that users that are not registered can access the system
        /// </summary>
        /// <returns>A default user instance representing a guest</returns>
        public LoggedInUser Login()
        {
            if (this.guestToken == null)
            {
                this.guestToken = HashingUtil.GenerateHash("guest");
            }
            //return new LoggedInUser(token: this.guestToken, username: null, name: null, roles: new List<Role>());
            return new LoggedInUser(new User(), this.guestToken);
        }

        /// <summary>
        /// Performs the user logout action. Deletes a valid token from the list of active tokens.
        /// </summary>
        /// <param name="token">The active token of the user</param>
        public void Logout(string token)
        {
            if (String.IsNullOrWhiteSpace(token))
            {
                throw new ArgumentException("Cannot perform the logout action with a null or empty token");
            }
            if (!token.Equals(this.guestToken))
            {
                if (!this._activeTokens.ContainsKey(token))
                {
                    throw new Exceptions.TokenNotFoundException("No such token was found as an active token");
                }
                this._activeTokens.Remove(token);
            }
        }


        public User GetCrawlerUser()
        {
           return Persistence.PersistenceFactory.GetUserPersistenceManagement().FindByUsername("Crawler");
        }
    }
}