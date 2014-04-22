using ObservaTerra.SessionManager.Managers.AdminModule;
using ObservaTerra.SessionManager.Managers.SessionProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservaTerra.SessionManager.Managers
{
    public class ManagersFactory
    {
        public static IAdminModuleServices GetAdminModuleServices()
        {
            return new AdminModuleServices();
        }

        public static ISessionProcessorServices GetSessionProcessorServices()
        {
            return new SessionProcessorServices();
        }
    }
}
