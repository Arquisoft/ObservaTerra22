using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Persistence
{
    class UserPersistenceManagement : IUserPersistenceManagement
    {
        /// <summary>
        /// Instance of the UserPersistenceManagement.
        /// </summary>
        private static UserPersistenceManagement instance;

        /// <summary>
        /// Private constructor. Only accessible inside the class
        /// </summary>
        private UserPersistenceManagement() { }

        /// <summary>
        /// Obtains and returns the UserPersistenceManagement instance.
        /// </summary>
        /// <returns>The UserPersistenceManagement instance</returns>
        public static UserPersistenceManagement GetInstance()
        {
            if (instance == null)
            {
                instance = new UserPersistenceManagement();
            }
            return instance;
        }

        /// <summary>
        /// Looks for a user in the system with a given username
        /// </summary>
        /// <param name="username">The username of the user to look for</param>
        /// <returns>The user with that username, or null if no such user was found</returns>
        public User FindByUsername(string username)
        {
            if (String.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("The username used to look for a user cannot be neither null nor empty");
            }
            User result = null;
            using (var container = new DomainModelContainer())
            {
                result = container.Users.Single(u => u.Username.Equals(username));
            }
            return result;
        }

        /// <summary>
        /// Saves a new user in the system
        /// </summary>
        /// <param name="user">The new user to save in the system</param>
        /// <returns>The new user saved in the system</returns>
        public User SaveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("The user to save in the system cannot be null");
            }
            using (var container = new DomainModelContainer())
            {
                container.Users.Add(user);
                container.SaveChanges();
            }
            return user;
        }

        /// <summary>
        /// Deletes a user from the system
        /// </summary>
        /// <param name="id">The id of the user to delete</param>
        /// <returns>The user deleted</returns>
        public User DeleteUser(int id)
        {
            User user = null;
            using (var container = new DomainModelContainer())
            {
                user = container.Users.Single(u => u.Id == id);
                if (user == null)
                {
                    throw new ArgumentException("Could not find a user with that id");
                }
                container.Users.Remove(user);
                container.SaveChanges();
            }
            return user;
        }
    }
}
