using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservaTerra.BackEnd.DataAcquisition;

namespace ObservaTerra.Backend.DataAcquisition
{
    class CrawlerService
    {
        static void Main(string[] args)
        {
            CrawlerService CR = new CrawlerService();
            CR.AddUri("http://apps.who.int/gho/athena/data/GHO/WHOSIS_000002,WHOSIS_000001,WHOSIS_000015?profile=xtab&format=html&x-topaxis=GHO;SEX&x-sideaxis=COUNTRY;YEAR&x-title=table&filter=COUNTRY:*;REGION:AFR;REGION:AMR;REGION:SEAR;REGION:EUR;REGION:EMR;REGION:WPR;SEX:*");
            CR.Crawl();
        }
        public WebCrawler Crawler { get; set; }
        public DataSources ToCrawl { get; set; }
        public CrawlerService()
        {
            Crawler = new WebCrawler();
            ToCrawl = ReadFromFile();
        }
        public void AddUri(string uri)
        {

            ToCrawl.Add(uri);
            UpdateFile();
        }

        private void UpdateFile()
        {
            XmlSerializer writer = new XmlSerializer(typeof(DataSources));
            using (FileStream file = File.OpenWrite("/sources/sources.xml"))
            {
                writer.Serialize(file, ToCrawl);
            }
        }
        public void RemoveUri(string uri)
        {
            ToCrawl.Remove(uri);
            UpdateFile();
        }
        public void Crawl()
        {
            ToCrawl.Sources.ForEach(x => Crawler.crawl(new Uri(x)));
        }

        private DataSources ReadFromFile()
        {

            XmlSerializer reader = new XmlSerializer(typeof(DataSources));
            using (FileStream input = File.OpenRead("/sources/sources.xml"))
            {
                return reader.Deserialize(input) as DataSources;
            }
        }
    }
}
