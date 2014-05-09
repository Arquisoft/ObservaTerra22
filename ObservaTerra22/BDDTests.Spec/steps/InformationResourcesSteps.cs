using ObservaTerra.Backend.DataCommand;
using ObservaTerra.Backend.DataQuery;
using ObservaTerra.DomainModel;
using System;
using System.Linq;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObservaTerra.Backend.WebService.Controllers;
using ObservaTerra.SessionManager.Managers.SessionProcessor;
using ObservaTerra.SessionManager.Persistence;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class InformationResourcesSteps
    {

        private Indicator crimeIndicator;

        [Given(@"a collection of public documents about some subjects")]
        public void GivenACollectionOfPublicDocumentsAboutSomeSubjects(Table table)
        {
            IIndicatorCommand command = DataCommandFactory.GetIndicatorCommand(null);
            IObservationCommand oCommand = DataCommandFactory.GetObservationCommand(null);
            Indicator indH = new Indicator { Name = "Hunger" };
            Indicator indP = new Indicator { Name = "Pollution" };
            Indicator indPv = new Indicator { Name = "Poverty" };
            Indicator indE = new Indicator { Name = "Education" };

            for (int i = 0; i < 164; i++)
            {
                Observation obs = new Observation { Name = "Observ" + i + new Random().Next(50000) };
                indH.Observations.Add(obs);
                oCommand.AddObservation(obs);
            }
            for (int i = 0; i < 49; i++)
            {
                Observation obs = new Observation { Name = "Observ" + i + new Random().Next(50000) };
                indP.Observations.Add(obs);
                oCommand.AddObservation(obs);
            }
            for (int i = 0; i < 143; i++)
            {
                Observation obs = new Observation { Name = "Observ" + i + new Random().Next(50000), IComponents = new List<IComponent>() };
                indPv.Observations.Add(obs);
                oCommand.AddObservation(obs);
            }
            for (int i = 0; i < 138; i++)
            {
                Observation obs = new Observation { Name = "Observ" + i + new Random().Next(50000) };
                indE.Observations.Add(obs);
                oCommand.AddObservation(obs);
            }
            command.AddIndicator(indH);
            command.AddIndicator(indP);
            command.AddIndicator(indPv);
            command.AddIndicator(indE);

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
            IIndicatorCommand command = DataCommandFactory.GetIndicatorCommand(null);
            IObservationCommand oCommand = DataCommandFactory.GetObservationCommand(null);
            Indicator indC = new Indicator { Name = "Crime" };

            for (int i = 0; i < 14; i++)
            {
                Observation obs = new Observation { Name = "Observ" + i + new Random().Next(50000), };
                indC.Observations.Add(obs);
                oCommand.AddObservation(obs);
            }
            command.AddIndicator(indC);
            this.crimeIndicator = indC;
        }

        [Given(@"a given resource stored in a given language")]
        public void GivenAGivenResourceStoredInAGivenLanguage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"a resource stored in the system")]
        public void GivenAResourceStoredInTheSystem()
        { }

        [When(@"the user asks for documents about hunger")]
        public void WhenTheUserAsksForDocumentsAboutHunger()
        { }

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
        { }

        [When(@"a registered user tries to add a new resource about that subject")]
        public void WhenARegisteredUserTriesToAddANewResourceAboutThatSubject()
        { }

        [When(@"a request for that resource in a different language arrives")]
        public void WhenARequestForThatResourceInADifferentLanguageArrives()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"a registered user asks for the source of a given resource")]
        public void WhenARegisteredUserAsksForTheSourceOfAGivenResource()
        { }

        [Then(@"the system will respond to such request with the (.*) documents related to hunger")]
        public void ThenTheSystemWillRespondToSuchRequestWithTheDocumentsRelatedToHunger(int p0)
        {
            IIndicatorQuery query = DataQueryFactory.GetIndicatorQuery(null);
            IEnumerable<Indicator> inds = query.FindIndicators("Hunger");
            int total = 0;
            foreach (Indicator i in inds)
            {
                total += i.Observations.Count;
            }
            Assert.AreEqual(164, total);
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
            ObservationController controller = new ObservationController();
            Observation newOb = new Observation
            {
                Name = "NewTestObservationDeny",
                Indicator = this.crimeIndicator
            };
            controller.Post(null, newOb);
            IObservationQuery query = DataQueryFactory.GetObservationQueries(null);
            Assert.AreEqual(14, query.FindObservations("Crime").Count());
        }

        [Then(@"the request will be accepted and the collection of resources will have n\+(.*) elements")]
        public void ThenTheRequestWillBeAcceptedAndTheCollectionOfResourcesWillHaveNElements(int p0)
        {
            RegisterController regController = new RegisterController();
            regController.Post(username: "testUs", password: "passUs");
            LoginController logController = new LoginController();
            LoggedInUser user = logController.Get(user: "testUs", pass: "passUs");
            ObservationController controller = new ObservationController();
            Observation newOb = new Observation
            {
                Name = "NewTestObservationAllowDeny",
                Indicator = this.crimeIndicator,
                UserAuthor = PersistenceFactory.GetUserPersistenceManagement().FindByUsername("testUs")
            };
            controller.Post(token: user.Token, observation: newOb);
            IObservationQuery query = DataQueryFactory.GetObservationQueries(null);
            Assert.AreEqual(15, query.FindObservations("Crime").Count());
            logController.Session.Logout(user.Token);
        }

        [Then(@"the system will show the resource in the language the user asked for")]
        public void ThenTheSystemWillShowTheResourceInTheLanguageTheUserAskedFor()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the system will shoe the source of the resource, that must be an organiization or another registered user, but never an unknown value")]
        public void ThenTheSystemWillShoeTheSourceOfTheResourceThatMustBeAnOrganiizationOrAnotherRegisteredUserButNeverAnUnknownValue()
        {
            LoginController logController = new LoginController();
            LoggedInUser user = logController.Get(user: "testUs", pass: "passUs");
            IObservationQuery query = DataQueryFactory.GetObservationQueries(null);
            Assert.IsNotNull(query.FindObservations("Crime").Last().UserAuthor);
            logController.Session.Logout(user.Token);
        }
    }
}
