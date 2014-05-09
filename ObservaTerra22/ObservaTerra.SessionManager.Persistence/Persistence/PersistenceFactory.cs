using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Persistence
{
    class PersistenceFactory
    {
        /// <summary>
        /// Factory method that creates a IUserPersistenceManagement instance
        /// </summary>
        /// <returns>A IUserPersistenceManagement instance</returns>
        public static IUserPersistenceManagement GetUserPersistenceManagement()
        {
            return UserPersistenceManagement.GetInstance();
        }

        /// <summary>
        /// Factory method that creates a IRolePersistenceManagement instance
        /// </summary>
        /// <returns>A IRolePersistenceManagement instance</returns>
        public static IRolePersistenceManagement GetRolePersistenceManagement()
        {
            return RolePersistenceManagement.GetInstance();
        }
    }
}
