using ObservaTerra.DomainModel;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
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
        private IDictionary<String, User> activeTokens = new Dictionary<String, User>();
        /// <summary>
        /// Token for guest users that are not registered in the system.
        /// </summary>
        private String guestToken = null;

        /// <summary>
        /// Performs the user login action and generates a token for that user
        /// </summary>
        /// <param name="username">The username of the user trying to login</param>
        /// <param name="password">The password of the user trying to login</param>
        /// <returns>The token generated for the user</returns>
        public String Login(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("In order to login a user, the username and password cannot be null or empty");
            }
            User user = Persistence.PersistenceFactory.GetUserPersistenceManagement().FindByUsername(username);
            if (user != null && user.Password.Equals(password))
            {
                String token = this.GenerateToken(username, new Random().Next(500));
                this.activeTokens.Add(token, user);
                return token;
            }
            throw new Exceptions.EntityNotFoundException("No user with that username and password was found in the system");
        }

        /// <summary>
        /// Creates a default guest user token so that users that are not registered can access the system
        /// </summary>
        /// <returns>A default guest token</returns>
        public String Login()
        {
            if (this.guestToken == null){
                this.guestToken = this.GenerateToken("guest");
            }
            return this.guestToken;
        }

        /// <summary>
        /// Performs the user logout action. Deletes a valid token from the list of active tokens.
        /// </summary>
        /// <param name="token">The active token of the user</param>
        public void Logout(String token)
        {
            if (String.IsNullOrWhiteSpace(token))
            {
                throw new ArgumentException("Cannot perform the logout action with a null or empty token");
            }
            if (!token.Equals(this.guestToken))
            {
                if (!this.activeTokens.ContainsKey(token))
                {
                    throw new Exceptions.TokenNotFoundException("No such token was found as an active token");
                }
                this.activeTokens.Remove(token);
            }
        }

        /// <summary>
        /// Generates a token for the user login operation. This token represents the user in the following operations during this session
        /// </summary>
        /// <param name="username">The username of the user</param>
        /// <param name="seed">The seed so that the same user gets two different tokens in two different login processes</param>
        /// <returns>The token generated for the user</returns>
        private String GenerateToken(String username, int seed = 0)
        {
            SHA256 mySHA = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(username + seed);
            String token = String.Empty;
            foreach (byte bit in bytes)
            {
                token += bit.ToString();
            }
            return token;
        }
    }
}
