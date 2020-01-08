using DependencyInjection.House.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class InternetService : IInternetService
    {
        private readonly ILogger logger;

        public InternetService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Use()
        {
            this.logger.LogInformation("Using boring ADSL internet");
        }
    }
}
