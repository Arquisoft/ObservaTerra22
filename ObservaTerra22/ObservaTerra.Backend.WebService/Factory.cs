using ObservaTerra.Backend.WebService.Controllers;
using ObservaTerra.SessionManager.Managers;
using ObservaTerra.SessionManager.Managers.SessionProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObservaTerra.Backend.WebService
{
    public class Factory
    {
        //This is fix the Web, if we used a web service, we wont need this...

        private static ISessionProcessorServices _sps;

        private static ISessionProcessorServices GetSPS()
        {
            if (_sps == null)
                _sps = ManagersFactory.GetSessionProcessorServices();
            return _sps;
        }

        private static LoginController _login = new LoginController() { Session = GetSPS() };

        public static LoginController GetLoginController()
        {
            return _login;
        }

        private static AreaController _area = new AreaController(){ Session = GetSPS() };

        public static AreaController GetAreaController()
        {
            return _area;
        }

        private static ComponentController _component = new ComponentController(){ Session = GetSPS() };

        public static ComponentController GetComponentController()
        {
            return _component;
        }

        private static IndicatorController _indicator = new IndicatorController(){ Session = GetSPS() };

        public static IndicatorController GetIndicatorController()
        {
            return _indicator;
        }

        private static ObservationController _observation = new ObservationController(){ Session = GetSPS() };

        public static ObservationController GetObservationController()
        {
            return _observation;
        }
    }
}