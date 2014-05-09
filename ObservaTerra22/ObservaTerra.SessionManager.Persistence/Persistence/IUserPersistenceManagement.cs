using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Persistence
{
    public interface IUserPersistenceManagement
    {
        /// <summary>
        /// Looks for a user in the system with a given username
        /// </summary>
        /// <param name="username">The username of the user to look for</param>
        /// <returns>The user with that username, or null if no such user was found</returns>
        User FindByUsername(string username);
        /// <summary>
        /// Saves a new user in the system
        /// </summary>
        /// <param name="user">The new user to save in the system</param>
        /// <returns>The new user saved in the system</returns>
        User SaveUser(User user);
        /// <summary>
        /// Deletes a user from the system
        /// </summary>
        /// <param name="id">The id of the user to delete</param>
        /// <returns>The user deleted</returns>
        User DeleteUser(int id);
    }
}
