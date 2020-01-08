using DependencyInjection.House.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class UltraCleaningService : ICleaningService
    {
        private readonly ILogger<UltraCleaningService> logger;

        public UltraCleaningService(ILogger<UltraCleaningService> logger)
        {
            this.logger = logger;
        }

        public void Use()
        {
            this.logger.LogInformation("This place has never been cleaner");
        }
    }
}
