using ObservaTerra.Backend.DataQuery;
using ObservaTerra.DomainModel;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class ObservationManagementSteps
    {
        [Given(@"a collection of observations about a specific indicator:")]
        public void GivenACollectionOfObservationsAboutASpecificIndicator(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"an empty collection of observations the system has stored about a given area or indicator")]
        public void GivenAnEmptyCollectionOfObservationsTheSystemHasStoredAboutAGivenAreaOrIndicator()
        {}

        [Given(@"a list of indicators about a specific issue:")]
        public void GivenAListOfIndicatorsAboutASpecificIssue(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"a new observation about that issue in China is added")]
        public void GivenANewObservationAboutThatIssueInChinaIsAdded()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the system obtains the mean of such indicator")]
        public void WhenTheSystemObtainsTheMeanOfSuchIndicator()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a request asking for that information arrives at the system")]
        public void WhenARequestAskingForThatInformationArrivesAtTheSystem()
        {}

        [When(@"the system is asked for observations about that issue in China")]
        public void WhenTheSystemIsAskedForObservationsAboutThatIssueInChina()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result must be equal to (.*)")]
        public void ThenTheResultMustBeEqualTo(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the system will notify the user that it has no information, so the result is empty")]
        public void ThenTheSystemWillNotifyTheUserThatItHasNoInformationSoTheResultIsEmpty()
        {
            IObservationQuery query = DataQueryFactory.GetObservationQueries(null);
            IEnumerable<Observation> result = query.FindObservations("RandomNotExistingName");
            Assert.IsTrue(result.Count() == 0);
        }

        [Then(@"the result sent back to the user will be formed by those (.*) observations stored in the system")]
        public void ThenTheResultSentBackToTheUserWillBeFormedByThoseObservationsStoredInTheSystem(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
