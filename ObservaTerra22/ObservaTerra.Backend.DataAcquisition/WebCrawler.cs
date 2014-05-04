using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abot.Crawler;
using Abot.Poco;
using ObservaTerra.DomainModel;

namespace ObservaTerra.Backend.DataAcquisition
{
    public class WebCrawler
    {
       public IList<IComponent> Files { get; set; }
        public PoliteWebCrawler Crawler { get; set; }
        public WebCrawler()
        {
            init();
        }

        public CrawlResult crawl(Uri uri)
        {
            return Crawler.Crawl(uri);
        }
        public void init() {
            Files = new List<IComponent>();
            CrawlConfiguration crawlConfig = new CrawlConfiguration();
            crawlConfig.CrawlTimeoutSeconds = 200;
            crawlConfig.MaxConcurrentThreads = 100;
            crawlConfig.DownloadableContentTypes = "text/html";
            crawlConfig.MaxPagesToCrawl = 10000;
            crawlConfig.IsExternalPageLinksCrawlingEnabled = false;
            crawlConfig.IsExternalPageLinksCrawlingEnabled = false;
            crawlConfig.UserAgentString = "abot v1.0 http://code.google.com/p/abot";
            crawlConfig.MaxCrawlDepth = 100;

            Crawler = new PoliteWebCrawler(crawlConfig, null, null, null, null, null, null, null, null);

            //crawler.PageCrawlStartingAsync += crawler_ProcessPageCrawlStarting;
            Crawler.PageCrawlCompletedAsync += crawler_ProcessPageCrawlCompleted;
            
        }
         void crawler_ProcessPageCrawlCompleted(object sender, PageCrawlCompletedArgs e)
        {
            CrawledPage crawledPage = e.CrawledPage;
            //System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "/crawlTmp.txt", crawledPage.Content.Text);

            if (crawledPage.Uri.AbsoluteUri.Contains(".csv"))
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    this.Files.Add(new TextComponent(client.DownloadString(crawledPage.Uri)));
                    Console.WriteLine("Downloaded file from {0}", crawledPage.Uri.AbsoluteUri);
                }
            }

            if (crawledPage.WebException != null || crawledPage.HttpWebResponse.StatusCode != System.Net.HttpStatusCode.OK)
                Console.WriteLine("Crawl of page failed {0}", crawledPage.Uri.AbsoluteUri);
            else
                Console.WriteLine("Crawl of page succeeded {0}", crawledPage.Uri.AbsoluteUri);

            if (string.IsNullOrEmpty(crawledPage.Content.Text))
                Console.WriteLine("Page had no content {0}", crawledPage.Uri.AbsoluteUri);
        }
    }
}
