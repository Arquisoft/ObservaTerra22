using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class SystemRegisterProcessSteps
    {
        [Given(@"a user not logged in the system")]
public void GivenAUserNotLoggedInTheSystem()
{
    ScenarioContext.Current.Pending();
}

        [When(@"such user sends a register request to the system")]
public void WhenSuchUserSendsARegisterRequestToTheSystem()
{
    ScenarioContext.Current.Pending();
}

        [When(@"completes successfully the register form with no errors")]
public void WhenCompletesSuccessfullyTheRegisterFormWithNoErrors()
{
    ScenarioContext.Current.Pending();
}

        [When(@"the ident the user is trying to use is already registered in the system")]
public void WhenTheIdentTheUserIsTryingToUseIsAlreadyRegisteredInTheSystem()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"a new account is created for such user")]
public void ThenANewAccountIsCreatedForSuchUser()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the system will notify the user of such conflict and no new account will be created")]
public void ThenTheSystemWillNotifyTheUserOfSuchConflictAndNoNewAccountWillBeCreated()
{
    ScenarioContext.Current.Pending();
}
    }
}
