using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatsdClient;

namespace DataDogIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Configire on localhost
            var DogStatsdConfig = new StatsdConfig
            {
                StatsdServerName = "127.0.0.1",
                StatsdPort = 8125,
                Prefix = "My-Test-App" 
            };

            // Apply configuration
            StatsdClient.DogStatsd.Configure(DogStatsdConfig);

            // Send an event
            DogStatsd.Increment("MyEvent");
        }
    }
}
