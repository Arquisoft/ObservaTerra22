using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Managers.SessionProcessor
{
    public interface ISessionProcessorServices
    {
        /// <summary>
        /// Performs the user login action and generates a token for that user
        /// </summary>
        /// <param name="username">The username of the user trying to login</param>
        /// <param name="password">The password of the user trying to login</param>
        /// <returns>The loggedinUser instance generated for the user</returns>
        LoggedInUser Login(string username, string password);
        /// <summary>
        /// Creates a default guest user token so that users that are not registered can access the system
        /// </summary>
        /// <returns>A default user instance representing a guest</returns>
        LoggedInUser Login();
        /// <summary>
        /// Performs the user logout action. Deletes a valid token from the list of active tokens.
        /// </summary>
        /// <param name="token">The active token of the user</param>
        void Logout(string token);

        IDictionary<string, User> ActiveTokens { get; }
    }
}
