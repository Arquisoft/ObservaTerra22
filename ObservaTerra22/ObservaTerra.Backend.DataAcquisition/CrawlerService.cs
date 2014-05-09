using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservaTerra.DomainModel;
using ObservaTerra.Backend.DataCommand;
using ObservaTerra.SessionManager.Managers.SessionProcessor;
using ObservaTerra.SessionManager.Managers;


namespace ObservaTerra.Backend.DataAcquisition
{
    public class CrawlerService
    {

        public static void Main(string[] args)
        {
            var cs = new CrawlerService();
            cs.Crawl();
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
                    result.AddRange (Crawler.Files);
                });

            ISessionProcessorServices sessionservice = ManagersFactory.GetSessionProcessorServices();
            IComponentCommand command = DataCommandFactory.GetComponentCommand(sessionservice.GetCrawlerUser());
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
