using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class InternetService
    {
        private readonly ILogger logger;

        public InternetService(ILogger logger)
        {
            this.logger = logger;
        }

        public void UseInternet()
        {
            this.logger.LogInformation("Using boring ADSL internet");
        }
    }
}
