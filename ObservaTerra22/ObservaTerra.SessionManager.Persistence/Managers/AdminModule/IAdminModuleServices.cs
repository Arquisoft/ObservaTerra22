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
        /// <param name="id">The user id to delete from the system</param>
        /// <returns>The deleted user</returns>
        User DeleteUser(int id);
        /// <summary>
        /// Saves a new role in the system
        /// </summary>
        /// <param name="role">The new role to save in the system</param>
        /// <returns>The new role</returns>
        Role RegisterRole(Role role);
        /// <summary>
        /// Deletes a role from the system
        /// </summary>
        /// <param name="id">The role id to delete from the system</param>
        /// <returns>The deleted role</returns>
        Role DeleteRole(int id);
    }
}
