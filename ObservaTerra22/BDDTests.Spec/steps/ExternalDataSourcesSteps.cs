using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObservaTerra.Backend.DataAcquisition;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class ExternalDataSourcesSteps
    {

        private CrawlerService service = new CrawlerService { Crawler = new WebCrawler(), ToCrawl = new DataSources() };
        private string testUri = "https://data.undp.org/dataset/Table-1-Human-Development-Index-and-its-components/wxub-qc5k";

        [Given(@"a collection of stored resources in the system about a given subject in a given area")]
        public void GivenACollectionOfStoredResourcesInTheSystemAboutAGivenSubjectInAGivenArea()
        { }

        [Given(@"a data source the system ObservaTerra is subscribed to has published a new resource about that subject in that area")]
        public void GivenADataSourceTheSystemObservaTerraIsSubscribedToHasPublishedANewResourceAboutThatSubjectInThatArea()
        { }

        [Given(@"a collection of external data sources ObservaTerra is subscribed to")]
        public void GivenACollectionOfExternalDataSourcesObservaTerraIsSubscribedTo()
        { }

        [Given(@"a collection of external data sources the system is subscribed to")]
        public void GivenACollectionOfExternalDataSourcesTheSystemIsSubscribedTo()
        {
            service.AddUri(testUri);
        }

        [When(@"the main system runs the external data acquisition system next time")]
        public void WhenTheMainSystemRunsTheExternalDataAcquisitionSystemNextTime()
        { }

        [When(@"the administrator subscribes the system to a new external data source")]
        public void WhenTheAdministratorSubscribesTheSystemToANewExternalDataSource()
        { }

        [When(@"the administrator removes one of the subscriptions from that collection")]
        public void WhenTheAdministratorRemovesOneOfTheSubscriptionsFromThatCollection()
        { }

        [Then(@"the collection of resources about that subject in that area will be one unit greater")]
        public void ThenTheCollectionOfResourcesAboutThatSubjectInThatAreaWillBeOneUnitGreater()
        {
            int files = 0;
            service.AddUri(testUri);
            int newFiles = 0;
            service.ToCrawl.Sources.ForEach(sourc =>
            {
                service.Crawler.crawl(new Uri(sourc));
                newFiles += service.Crawler.Files.Count;
            });
            Assert.IsTrue(newFiles != 0 && newFiles > files);
        }

        [Then(@"the collection of external data sources subscribed to will be one unit greater")]
        public void ThenTheCollectionOfExternalDataSourcesSubscribedToWillBeOneUnitGreater()
        {
            int oldSize = service.ToCrawl.Sources.Count;
            service.AddUri(testUri);
            int newSize = service.ToCrawl.Sources.Count;
            Assert.IsTrue(newSize > oldSize && newSize == oldSize + 1);
        }

        [Then(@"the collection of subscriptions will be one unit smaller")]
        public void ThenTheCollectionOfSubscriptionsWillBeOneUnitSmaller()
        {
            int oldSize = service.ToCrawl.Sources.Count;
            service.RemoveUri(testUri);
            int newSize = service.ToCrawl.Sources.Count;
            Assert.IsTrue(newSize < oldSize && newSize == oldSize - 1);
        }

        [Then(@"the next time the external data acquisition system is executed, none of the crawlers will analyze the data source that was just deleted from the collection")]
        public void ThenTheNextTimeTheExternalDataAcquisitionSystemIsExecutedNoneOfTheCrawlersWillAnalyzeTheDataSourceThatWasJustDeletedFromTheCollection()
        {
            service.RemoveUri(testUri);
            int newFiles = 0;
            service.ToCrawl.Sources.ForEach(sourc =>
            {
                service.Crawler.crawl(new Uri(sourc));
                newFiles += service.Crawler.Files.Count;
            });
            Assert.AreEqual(0, newFiles);
        }
    }
}
