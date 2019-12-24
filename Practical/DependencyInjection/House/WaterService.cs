using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class WaterService
    {
        private readonly ILogger<WaterService> logger;

        public WaterService(ILogger<WaterService> logger)
        {
            this.logger = logger;
        }

        public void UseWater()
        {
            this.logger.LogInformation("Clean, running water is over looked way too often.");
        }
    }
}
