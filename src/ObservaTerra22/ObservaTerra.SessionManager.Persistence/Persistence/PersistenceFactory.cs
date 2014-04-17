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
        /// Factory method that creates IUserPersistenceManagement instances
        /// </summary>
        /// <returns>A IUserPersistenceManagement instance</returns>
        public static IUserPersistenceManagement GetUserPersistenceManagement()
        {
            return UserPersistenceManagement.GetInstance();
        }
    }
}
