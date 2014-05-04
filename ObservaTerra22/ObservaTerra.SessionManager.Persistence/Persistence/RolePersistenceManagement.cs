using System;
using System.Collections.Generic;
using ObservaTerra.DomainModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Persistence
{
    class RolePersistenceManagement : IRolePersistenceManagement
    {
        /// <summary>
        /// Instance of the RolePersistenceManagement.
        /// </summary>
        private static RolePersistenceManagement instance;

        /// <summary>
        /// Private constructor. Only accessible inside the class
        /// </summary>
        private RolePersistenceManagement() { }

        /// <summary>
        /// Obtains and returns the RolePersistenceManagement instance.
        /// </summary>
        /// <returns>The RolePersistenceManagement instance</returns>
        public static RolePersistenceManagement GetInstance()
        {
            if (instance == null)
            {
                instance = new RolePersistenceManagement();
            }
            return instance;
        }

        /// <summary>
        /// Saves a new role in the system
        /// </summary>
        /// <param name="role">The new role to save in the system</param>
        /// <returns>The new role saved in the system</returns>
        public Role SaveRole(Role role)
        {
            if (role == null)
            {
                throw new ArgumentNullException("The role to save in the system cannot be null");
            }
            using (var container = new DomainModelContainer())
            {
                container.RoleSet.Add(role);
                container.SaveChanges();
            }
            return role;
        }

        /// <summary>
        /// Deletes a role from the system
        /// </summary>
        /// <param name="id">The id of the role to delete</param>
        /// <returns>The role deleted</returns>
        public Role DeleteRole(int id)
        {
            Role role = null;
            using (var container = new DomainModelContainer())
            {
                role = container.RoleSet.Single(u => u.Id == id);
                if (role == null)
                {
                    throw new ArgumentException("Could not find a role with that id");
                }
                container.RoleSet.Remove(role);
                container.SaveChanges();
            }
            return role;
        }

        /// <summary>
        /// Looks for a role with a given name
        /// </summary>
        /// <param name="name">The name to look for</param>
        /// <returns>The role with that name, or null if no such role exists</returns>
        public Role FindByName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The name used to look for a role cannot be neither null nor empty");
            }
            Role result = null;
            using (var container = new DomainModelContainer())
            {
                result = container.RoleSet.Single(u => u.Name.Equals(name));
            }
            return result;
        }
    }
}
