using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ObservaTerra.Backend.DataAcquisition;
namespace DataCollector
{
    class Collector
    {
        static void Main(string[] args)
        {
            Boolean run = true;
            while (run)
            {
                CrawlerService service = new CrawlerService();
                service.Crawl();
                TimeSpan wait = new TimeSpan(1,0,0,0);//one day
                System.Threading.Thread.Sleep(wait);
            }
        }
    }
}
