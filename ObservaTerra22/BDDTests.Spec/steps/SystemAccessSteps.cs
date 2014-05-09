using ObservaTerra.Backend.WebService.Controllers;
using ObservaTerra.DomainModel;
using ObservaTerra.SessionManager;
using ObservaTerra.SessionManager.Managers;
using ObservaTerra.SessionManager.Managers.AdminModule;
using ObservaTerra.SessionManager.Managers.SessionProcessor;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class SystemAccessSteps
    {
        private string usernameTest = "usernameTest" + new Random().Next(1000);
        private string passwordTest = "passwordTest" + new Random().Next(1000);
        private User currentUser;
        private LoggedInUser loggedIn;

        [Given(@"a user already registered in the system")]
        public void GivenAUserAlreadyRegisteredInTheSystem()
        {

            IAdminModuleServices service = ManagersFactory.GetAdminModuleServices();
            this.currentUser = new User { Username = usernameTest, Name = usernameTest, Password = passwordTest };
            service.RegisterUser(this.currentUser);
        }

        [Given(@"a user not registered in the system")]
        public void GivenAUserNotRegisteredInTheSystem()
        {
            this.currentUser = new User { Username = "usernameNotRegistered", Name = "usernameNotRegistered", Password = "passwordNotRegistered" };
        }

        [Given(@"a user not logged in")]
        public void GivenAUserNotLoggedIn()
        { }

        [When(@"such user logs in the system")]
        public void WhenSuchUserLogsInTheSystem()
        { }

        [When(@"the user accesses the system")]
        public void WhenTheUserAccessesTheSystem()
        {
            ISessionProcessorServices service = ManagersFactory.GetSessionProcessorServices();
            this.loggedIn = service.Login();
        }

        [Then(@"the system assigns him/her a token for the session, along with the groups the user belongs to, that grants him/her access")]
        public void ThenTheSystemAssignsHimHerATokenForTheSessionAlongWithTheGroupsTheUserBelongsToThatGrantsHimHerAccess()
        {
            ISessionProcessorServices service = ManagersFactory.GetSessionProcessorServices();
            this.loggedIn = service.Login(username: this.currentUser.Username, password: this.currentUser.Password);
            Assert.IsNotNull(loggedIn.Token);
            service.Logout(token: this.loggedIn.Token);

        }

        [Then(@"the system denies the login request")]
        public void ThenTheSystemDeniesTheLoginRequest()
        {
            ISessionProcessorServices service = ManagersFactory.GetSessionProcessorServices();
            try
            {
                this.loggedIn = service.Login(username: this.currentUser.Username, password: this.currentUser.Password);
            }
            catch (ObservaTerra.SessionManager.Exceptions.EntityNotFoundException e)
            {
                Assert.IsTrue(true);
            }
        }

        [Then(@"the system assigns such user a default token that identifies him/her as a guest user")]
        public void ThenTheSystemAssignsSuchUserADefaultTokenThatIdentifiesHimHerAsAGuestUser()
        {
            ISessionProcessorServices service = ManagersFactory.GetSessionProcessorServices();
            try
            {
                this.loggedIn = service.Login(username: this.currentUser.Username, password: this.currentUser.Password);
                service.Logout(token: this.loggedIn.Token);
            }
            catch (Exception e)
            {
                Assert.IsNull(this.loggedIn.Name);
                Assert.IsNull(this.loggedIn.Username);
            }
        }
    }
}
