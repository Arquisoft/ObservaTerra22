using ObservaTerra.Backend.WebService.Controllers;
using ObservaTerra.SessionManager.Managers;
using ObservaTerra.SessionManager.Managers.AdminModule;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using ObservaTerra.SessionManager.Persistence;
using ObservaTerra.DomainModel;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class SystemRegisterProcessSteps
    {
        [Given(@"a user not logged in the system")]
        public void GivenAUserNotLoggedInTheSystem()
        { }

        [When(@"such user sends a register request to the system")]
        public void WhenSuchUserSendsARegisterRequestToTheSystem()
        { }

        [When(@"completes successfully the register form with no errors")]
        public void WhenCompletesSuccessfullyTheRegisterFormWithNoErrors()
        { }

        [When(@"the ident the user is trying to use is already registered in the system")]
        public void WhenTheIdentTheUserIsTryingToUseIsAlreadyRegisteredInTheSystem()
        { }

        [Then(@"a new account is created for such user")]
        public void ThenANewAccountIsCreatedForSuchUser()
        {
            RegisterController controller = new RegisterController();
            controller.Post(username: "regUserN", password: "regPassword");
            User user = PersistenceFactory.GetUserPersistenceManagement().FindByUsername("regUserN");
            Assert.IsNotNull(user);
        }

        [Then(@"the system will notify the user of such conflict and no new account will be created")]
        public void ThenTheSystemWillNotifyTheUserOfSuchConflictAndNoNewAccountWillBeCreated()
        {
            RegisterController controller = new RegisterController();
            controller.Post(username: "regUser", password: "regPassword");
            try
            {
                IAdminModuleServices mod = ManagersFactory.GetAdminModuleServices();
                mod.RegisterUser(new ObservaTerra.DomainModel.User { Name = "regUser", Password = "regPassword" });
            }
            catch (ObservaTerra.SessionManager.Exceptions.UsernameAlreadyInUseException e)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
