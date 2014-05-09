using System;
using System.Collections.Generic;
using ObservaTerra.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Persistence
{
    public interface IRolePersistenceManagement
    {
        /// <summary>
        /// Saves a new role in the system
        /// </summary>
        /// <param name="role">The new role to save in the system</param>
        /// <returns>The new role saved in the system</returns>
        Role SaveRole(Role role);
        /// <summary>
        /// Deletes a role from the system
        /// </summary>
        /// <param name="id">The id of the role to delete</param>
        /// <returns>The role deleted</returns>
        Role DeleteRole(int id);
        /// <summary>
        /// Looks for a role with a given name
        /// </summary>
        /// <param name="name">The name to look for</param>
        /// <returns>The role with that name, or null if no such role exists</returns>
        Role FindByName(string name);
    }
}
