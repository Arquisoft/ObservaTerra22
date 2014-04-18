using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Managers.AdminModule
{
    public interface IAdminModuleServices
    {
        /// <summary>
        /// Saves a new user in the system
        /// </summary>
        /// <param name="user">The new user to add to the system</param>
        /// <returns>The new user</returns>
        User RegisterUser(User user);

        /// <summary>
        /// Deletes a user from the system
        /// </summary>
        /// <param name="id">The user id to delet from the system</param>
        /// <returns>The deleted user</returns>
        User DeleteUser(int id);
    }
}
