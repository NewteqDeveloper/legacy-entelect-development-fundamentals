using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class CleaningService
    {
        private readonly ILogger<CleaningService> logger;

        public CleaningService(ILogger<CleaningService> logger)
        {
            this.logger = logger;
        }

        public void Use()
        {
            this.logger.LogInformation("Using the cleaning service, they are doing an OK job");
        }
    }
}
