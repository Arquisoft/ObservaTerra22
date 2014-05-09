using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class ExternalDataAcquisitionSystemSteps
    {
        [Given(@"a new data acquisition system that is added to the system, no matter its programming language")]
        public void GivenANewDataAcquisitionSystemThatIsAddedToTheSystemNoMatterItsProgrammingLanguage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"a list of external data sources the system is subscribed to")]
        public void GivenAListOfExternalDataSourcesTheSystemIsSubscribedTo()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"all the data acquisition elements are executed")]
        public void WhenAllTheDataAcquisitionElementsAreExecuted()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the data acquisition elements are executed")]
        public void WhenTheDataAcquisitionElementsAreExecuted()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"this new acquisition system will be executed too, and its results will be processed as well")]
        public void ThenThisNewAcquisitionSystemWillBeExecutedTooAndItsResultsWillBeProcessedAsWell()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the main system won't stop executing at any moment")]
        public void ThenTheMainSystemWonTStopExecutingAtAnyMoment()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all the external data sources that the system is subscribed to will be analyzed, and their results will be processed")]
        public void ThenAllTheExternalDataSourcesThatTheSystemIsSubscribedToWillBeAnalyzedAndTheirResultsWillBeProcessed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
