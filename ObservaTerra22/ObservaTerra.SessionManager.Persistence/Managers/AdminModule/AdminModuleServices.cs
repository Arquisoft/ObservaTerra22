using ObservaTerra.DomainModel;
using System;
using ObservaTerra.SessionManager.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Managers.AdminModule
{
    class AdminModuleServices : IAdminModuleServices
    {
        private IUserPersistenceManagement userManagement = PersistenceFactory.GetUserPersistenceManagement();
        private IRolePersistenceManagement roleManagement = PersistenceFactory.GetRolePersistenceManagement();

        /// <summary>
        /// Saves a new user in the system
        /// </summary>
        /// <param name="user">The new user to add to the system</param>
        /// <returns>The new user</returns>
        public User RegisterUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("The new user to add to the system cannot be null");
            }
            if (userManagement.FindByUsername(user.Username) != null)
            {
                throw new Exceptions.UsernameAlreadyInUseException("There is already a user with the username " + user.Username);
            }
            user.Password = HashingUtil.GenerateHash(user.Password);
            return userManagement.SaveUser(user);
        }

        /// <summary>
        /// Deletes a user from the system
        /// </summary>
        /// <param name="id">The user id to delet from the system</param>
        /// <returns>The deleted user</returns>
        public User DeleteUser(int id)
        {
            return userManagement.DeleteUser(id);
        }

        /// <summary>
        /// Saves a new role in the system
        /// </summary>
        /// <param name="role">The new role to save in the system</param>
        /// <returns>The new role saved in the system</returns>
        public Role RegisterRole(Role role)
        {
            if (role == null)
            {
                throw new ArgumentNullException("The new role to add to the system cannot be null");
            }
            if (roleManagement.FindByName(role.Name) != null)
            {
                throw new Exceptions.RoleNameAlreadyInUseException("There is already a role with the name " + role.Name);
            }
            return roleManagement.SaveRole(role);
        }

        /// <summary>
        /// Deletes a role from the system
        /// </summary>
        /// <param name="id">The id of the role to delete</param>
        /// <returns>The role deleted</returns>
        public Role DeleteRole(int id)
        {
            return roleManagement.DeleteRole(id);
        }
    }
}