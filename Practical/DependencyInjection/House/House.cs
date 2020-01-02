using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class House
    {
        private readonly ElectricityService electricityService;
        private readonly WaterService waterService;
        private readonly InternetService internetService;
        private readonly CleaningService cleaningService;
        private readonly SanitationService sanitationService;

        public House(
            ElectricityService electricityService,
            WaterService waterService,
            InternetService internetService,
            CleaningService cleaningService,
            SanitationService sanitationService)
        {
            this.electricityService = electricityService;
            this.waterService = waterService;
            this.internetService = internetService;
            this.cleaningService = cleaningService;
            this.sanitationService = sanitationService;
        }

        public void LiveInHouse()
        {
            this.electricityService.Use();
            this.waterService.UseWater();
            this.internetService.UseInternet();
            this.cleaningService.Clean();
            this.sanitationService.UseSanitation();
        }

        public void UseService(HouseService service)
        {
            switch (service)
            {
                case HouseService.Electricity:
                    this.electricityService.Use();
                    break;
                case HouseService.Water:
                    this.waterService.UseWater();
                    break;
                case HouseService.Internet:
                    this.internetService.UseInternet();
                    break;
                case HouseService.Cleaning:
                    this.cleaningService.Clean();
                    break;
                case HouseService.Sanitation:
                    this.sanitationService.UseSanitation();
                    break;
            }
        }
    }
}
