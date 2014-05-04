using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class InformationResourcesSteps
    {
        [Given(@"a collection of public documents about some subjects")]
public void GivenACollectionOfPublicDocumentsAboutSomeSubjects(Table table)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a collection of resources about a given subject:")]
public void GivenACollectionOfResourcesAboutAGivenSubject(Table table)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a collection of resources about a given subject")]
public void GivenACollectionOfResourcesAboutAGivenSubject()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a collection of n resources about a given subject")]
public void GivenACollectionOfNResourcesAboutAGivenSubject()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a given resource stored in a given language")]
public void GivenAGivenResourceStoredInAGivenLanguage()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a resource stored in the system")]
public void GivenAResourceStoredInTheSystem()
{
    ScenarioContext.Current.Pending();
}

        [When(@"the user asks for documents about hunger")]
public void WhenTheUserAsksForDocumentsAboutHunger()
{
    ScenarioContext.Current.Pending();
}

        [When(@"a guest user asks for information about that subject")]
public void WhenAGuestUserAsksForInformationAboutThatSubject()
{
    ScenarioContext.Current.Pending();
}

        [When(@"a user asks for information about that given subject, but has no privileges to access any of the documents related to the subject")]
public void WhenAUserAsksForInformationAboutThatGivenSubjectButHasNoPrivilegesToAccessAnyOfTheDocumentsRelatedToTheSubject()
{
    ScenarioContext.Current.Pending();
}

        [When(@"a guest user tries to add a new resource about that subject")]
public void WhenAGuestUserTriesToAddANewResourceAboutThatSubject()
{
    ScenarioContext.Current.Pending();
}

        [When(@"a registered user tries to add a new resource about that subject")]
public void WhenARegisteredUserTriesToAddANewResourceAboutThatSubject()
{
    ScenarioContext.Current.Pending();
}

        [When(@"a request for that resource in a different language arrives")]
public void WhenARequestForThatResourceInADifferentLanguageArrives()
{
    ScenarioContext.Current.Pending();
}

        [When(@"a registered user asks for the source of a given resource")]
public void WhenARegisteredUserAsksForTheSourceOfAGivenResource()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the system will respond to such request with the (.*) documents related to hunger")]
public void ThenTheSystemWillRespondToSuchRequestWithTheDocumentsRelatedToHunger(int p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the system will respond with the (.*) public documents about that subject")]
public void ThenTheSystemWillRespondWithThePublicDocumentsAboutThatSubject(int p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"no document will be sent back to the user")]
public void ThenNoDocumentWillBeSentBackToTheUser()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the request will be denied and the collection of resources will have n elements still")]
public void ThenTheRequestWillBeDeniedAndTheCollectionOfResourcesWillHaveNElementsStill()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the request will be accepted and the collection of resources will have n\+(.*) elements")]
public void ThenTheRequestWillBeAcceptedAndTheCollectionOfResourcesWillHaveNElements(int p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the system will show the resource in the language the user asked for")]
public void ThenTheSystemWillShowTheResourceInTheLanguageTheUserAskedFor()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the system will shoe the source of the resource, that must be an organiization or another registered user, but never an unknown value")]
public void ThenTheSystemWillShoeTheSourceOfTheResourceThatMustBeAnOrganiizationOrAnotherRegisteredUserButNeverAnUnknownValue()
{
    ScenarioContext.Current.Pending();
}
    }
}
