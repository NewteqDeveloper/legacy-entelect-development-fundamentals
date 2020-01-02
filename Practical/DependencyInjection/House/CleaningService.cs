using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class CleaningService
    {
        private readonly ILogger logger;

        public CleaningService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Clean()
        {
            this.logger.LogInformation("Using the cleaning service, they are doing an OK job");
        }
    }
}
