using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaPrinciples.Animals;
using MetaPrinciples.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MetaPrinciples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FarmController : ControllerBase
    {
        private readonly ILogger<FarmController> logger;
        private readonly AnimalDb animalDb;

        public FarmController(ILogger<FarmController> logger, AnimalDb animalDb)
        {
            this.logger = logger;
            this.animalDb = animalDb;

            // this is the place for the animals to interact
            // maybe have list a static list of animals that can be created and they can interact with each other
            // or maybe just one animal per type interacts

            // the idea is to maybe have an enum of all the animals and then take in two and have them interact with each other
            // the before that solution will be to have a method per different type of interaction

            // think about seperation of concerns and least knowledge too
            // least astonishment should be easy enough, with the open db connection in one method and the close in another
        }

        [HttpGet]
        [Route("getAll")]
        public IList<Animal> GetAllAnimals()
        {
            return animalDb.Animals();
        }

        [HttpGet]
        [Route("getAllCats")]
        public List<Animal> GetAllCats()
        {
            return animalDb.Animals().Where(x => x.Type == AnimalType.Cat).ToList();
        }

        [HttpGet]
        [Route("getDogs")]
        public IEnumerable<Animal> GetAllDogs()
        {
            return animalDb.Animals().Where(x => x.Type == AnimalType.Dog);
        }

        [HttpGet]
        [Route("getTheCowsOnTheFarm")]
        public IActionResult GetAllCows()
        {
            return Ok(animalDb.Animals().Where(x => x.Type == AnimalType.Cow));
        }
    }
}
