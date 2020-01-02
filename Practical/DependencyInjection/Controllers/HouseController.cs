using DependencyInjection.House;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HouseController : ControllerBase
    {
        private readonly House.House house;
        
        public HouseController(ILogger logger)
        {
            house = new House.House(
                new House.ElectricityService(logger),
                new House.WaterService(logger),
                new House.InternetService(logger),
                new House.CleaningService(logger),
                new House.SanitationService(logger));
        }

        [HttpGet]
        public IActionResult LiveInHouse()
        {
            house.LiveInHouse();
            return Ok();
        }

        [HttpGet]
        public IActionResult UseHouseService(HouseService service)
        {
            house.UseService(service);
            return Ok();
        }
    }
}
