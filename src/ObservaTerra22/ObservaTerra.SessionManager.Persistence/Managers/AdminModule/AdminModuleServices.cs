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
        private IUserPersistenceManagement management = PersistenceFactory.GetUserPersistenceManagement();

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
            if (management.FindByUsername(user.Username) != null)
            {
                throw new Exceptions.UsernameAlreadyInUseException("There is already a user with the username " + user.Username);
            }
            user.Password = HashingUtil.GenerateHash(user.Password);
            return management.SaveUser(user);
        }

        /// <summary>
        /// Deletes a user from the system
        /// </summary>
        /// <param name="id">The user id to delet from the system</param>
        /// <returns>The deleted user</returns>
        public User DeleteUser(int id)
        {
            return management.DeleteUser(id);
        }
    }
}
