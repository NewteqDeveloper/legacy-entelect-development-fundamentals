using DependencyInjection.House.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class House : IHouse
    {
        private readonly IElectricityService electricityService;
        private readonly IWaterService waterService;
        private readonly IInternetService internetService;
        private readonly ICleaningService cleaningService;
        private readonly ISanitationService sanitationService;

        private readonly Dictionary<HouseService, IHouseHoldService> services;

        public House(
            IElectricityService electricityService,
            IWaterService waterService,
            IInternetService internetService,
            ICleaningService cleaningService,
            ISanitationService sanitationService)
        {
            this.electricityService = electricityService;
            this.waterService = waterService;
            this.internetService = internetService;
            this.cleaningService = cleaningService;
            this.sanitationService = sanitationService;

            this.services.Add(HouseService.Electricity, this.electricityService);
            this.services.Add(HouseService.Water, this.waterService);
            this.services.Add(HouseService.Internet, this.internetService);
            this.services.Add(HouseService.Cleaning, this.cleaningService);
            this.services.Add(HouseService.Sanitation, this.sanitationService);
        }

        public void LiveInHouse()
        {
            this.electricityService.Use();
            this.waterService.Use();
            this.internetService.Use();
            this.cleaningService.Use();
            this.sanitationService.Use();

            // alternatively
            foreach(var item in services)
            {
                item.Value.Use();
            }
        }

        public void UseService(HouseService service)
        {
            services[service].Use();
        }
    }
}
