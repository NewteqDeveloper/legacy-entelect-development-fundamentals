using DependencyInjection.House;
using DependencyInjection.House.Interfaces;
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
        private readonly IHouse house;

        public HouseController(ILogger<HouseController> logger, IHouse house)
        {
            this.house = house;
        }

        [HttpGet]
        [Route("live")]
        public IActionResult LiveInHouse()
        {
            house.LiveInHouse();
            return Ok();
        }

        [HttpGet]
        [Route("use")]
        public IActionResult UseHouseService(HouseService service)
        {
            house.UseService(service);
            return Ok();
        }
    }
}
