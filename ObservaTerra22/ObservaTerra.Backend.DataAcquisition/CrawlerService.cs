using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservaTerra.DomainModel;
using ObservaTerra.Backend.DataCommand;


namespace ObservaTerra.Backend.DataAcquisition
{
    public class CrawlerService
    {
        
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
            using (FileStream file = File.OpenWrite("sources/sources.xml"))
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
            List<IComponent> result = new List<IComponent>();
            ToCrawl.Sources.ForEach(
                x =>
                {
                    Crawler.crawl(new Uri(x));
                    result.Concat(Crawler.Files);
                });
                IComponentCommand command = DataCommandFactory.GetComponentCommand(new User() { Name = "Crawler", Username = "Crawler" });
                command.AddComponents(result);
        }

        private DataSources ReadFromFile()
        {

            XmlSerializer reader = new XmlSerializer(typeof(DataSources));
            using (FileStream input = File.OpenRead("sources/sources.xml"))
            {
                return reader.Deserialize(input) as DataSources;
            }
        }
    }
}
