using DependencyInjection.House.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class SolarPowerService : IElectricityService
    {
        private readonly ILogger<SolarPowerService> logger;

        public SolarPowerService(ILogger<SolarPowerService> logger)
        {
            this.logger = logger;
        }

        public void Use()
        {
            this.logger.LogInformation("Using solar power for our engery needs");
        }
    }
}
