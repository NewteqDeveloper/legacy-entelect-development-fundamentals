using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class InternetService
    {
        private readonly ILogger<InternetService> logger;

        public InternetService(ILogger<InternetService> logger)
        {
            this.logger = logger;
        }

        public void Use()
        {
            this.logger.LogInformation("Using boring ADSL internet");
        }
    }
}
