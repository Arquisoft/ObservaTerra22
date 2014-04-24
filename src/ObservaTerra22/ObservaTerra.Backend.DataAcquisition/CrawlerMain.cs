using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservaTerra.BackEnd.DataAcquisition;

namespace ObservaTerra22.Backend.DataAcquisition
{
    class CrawlerMain
    {
        static void Main(string[] args)
        {
            CrawlerMain CR = new CrawlerMain();
            CR.addUri(new Uri("http://apps.who.int/gho/athena/data/GHO/WHOSIS_000002,WHOSIS_000001,WHOSIS_000015?profile=xtab&format=html&x-topaxis=GHO;SEX&x-sideaxis=COUNTRY;YEAR&x-title=table&filter=COUNTRY:*;REGION:AFR;REGION:AMR;REGION:SEAR;REGION:EUR;REGION:EMR;REGION:WPR;SEX:*"));
            CR.crawl();
        }
        public WebCrawler Crawler{ get; set; }
        public List<Uri> ToCrawl { get; set; }
        public CrawlerMain()
        {
            Crawler = new WebCrawler();
            ToCrawl = new List<Uri>();
        }
        public void addUri(Uri uri)
        {
            ToCrawl.Add(uri);
        }
        public void removeUri(Uri uri)
        {
            ToCrawl.Remove(uri);
        }
        public void crawl()
        {
            ToCrawl.ForEach(x => Crawler.crawl(x));
        }
    }
}
