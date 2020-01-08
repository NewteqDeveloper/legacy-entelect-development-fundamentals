using DependencyInjection.House.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class FibreInternetService : IInternetService
    {
        private readonly ILogger<FibreInternetService> logger;

        public FibreInternetService(ILogger<FibreInternetService> logger)
        {
            this.logger = logger;
        }

        public void Use()
        {
            this.logger.LogInformation("We've got the fastest internet available now!");
        }
    }
}
