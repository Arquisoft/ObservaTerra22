using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class ExternalDataSourcesSteps
    {
        [Given(@"a collection of stored resources in the system about a given subject in a given area")]
public void GivenACollectionOfStoredResourcesInTheSystemAboutAGivenSubjectInAGivenArea()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a data source the system ObservaTerra is subscribed to has published a new resource about that subject in that area")]
public void GivenADataSourceTheSystemObservaTerraIsSubscribedToHasPublishedANewResourceAboutThatSubjectInThatArea()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a collection of external data sources ObservaTerra is subscribed to")]
public void GivenACollectionOfExternalDataSourcesObservaTerraIsSubscribedTo()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"a collection of external data sources the system is subscribed to")]
public void GivenACollectionOfExternalDataSourcesTheSystemIsSubscribedTo()
{
    ScenarioContext.Current.Pending();
}

        [When(@"the main system runs the external data acquisition system next time")]
public void WhenTheMainSystemRunsTheExternalDataAcquisitionSystemNextTime()
{
    ScenarioContext.Current.Pending();
}

        [When(@"the administrator subscribes the system to a new external data source")]
public void WhenTheAdministratorSubscribesTheSystemToANewExternalDataSource()
{
    ScenarioContext.Current.Pending();
}

        [When(@"the administrator removes one of the subscriptions from that collection")]
public void WhenTheAdministratorRemovesOneOfTheSubscriptionsFromThatCollection()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the collection of resources about that subject in that area will be one unit greater")]
public void ThenTheCollectionOfResourcesAboutThatSubjectInThatAreaWillBeOneUnitGreater()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the collection of external data sources subscribed to will be one unit greater")]
public void ThenTheCollectionOfExternalDataSourcesSubscribedToWillBeOneUnitGreater()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the collection of subscriptions will be one unit smaller")]
public void ThenTheCollectionOfSubscriptionsWillBeOneUnitSmaller()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the next time the external data acquisition system is executed, none of the crawlers will analyze the data source that was just deleted from the collection")]
public void ThenTheNextTimeTheExternalDataAcquisitionSystemIsExecutedNoneOfTheCrawlersWillAnalyzeTheDataSourceThatWasJustDeletedFromTheCollection()
{
    ScenarioContext.Current.Pending();
}
    }
}
