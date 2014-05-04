using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class SystemAccessSteps
    {
        [Given(@"a user already registered in the system")]
public void GivenAUserAlreadyRegisteredInTheSystem()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a user not registered in the system")]
public void GivenAUserNotRegisteredInTheSystem()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a user not logged in")]
public void GivenAUserNotLoggedIn()
{
    ScenarioContext.Current.Pending();
}

        [When(@"such user logs in the system")]
public void WhenSuchUserLogsInTheSystem()
{
    ScenarioContext.Current.Pending();
}

        [When(@"the user accesses the system")]
public void WhenTheUserAccessesTheSystem()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the system assigns him/her a token for the session, along with the groups the user belongs to, that grants him/her access")]
public void ThenTheSystemAssignsHimHerATokenForTheSessionAlongWithTheGroupsTheUserBelongsToThatGrantsHimHerAccess()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the system denies the login request")]
public void ThenTheSystemDeniesTheLoginRequest()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the system assigns such user a default token that identifies him/her as a guest user")]
public void ThenTheSystemAssignsSuchUserADefaultTokenThatIdentifiesHimHerAsAGuestUser()
{
    ScenarioContext.Current.Pending();
}
    }
}
