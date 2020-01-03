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
        private readonly AnimalService animalService;

        public FarmController(ILogger<FarmController> logger, AnimalService animalDb)
        {
            this.logger = logger;
            this.animalService = animalDb;

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
            return animalService.Animals();
        }

        [HttpGet]
        [Route("getAllCats")]
        public List<Animal> GetAllCats()
        {
            return animalService.Animals().Where(x => x.Type == AnimalType.Cat).ToList();
        }

        [HttpGet]
        [Route("getDogs")]
        public IEnumerable<Animal> GetAllDogs()
        {
            return animalService.GetAllDogs();
        }

        [HttpGet]
        [Route("getTheCowsOnTheFarm")]
        public IActionResult GetAllCows()
        {
            animalService.GetAnimals();
            return Ok(animalService.GetCows());
        }

        [HttpGet]
        [Route("whatDoesTheDogSay")]
        public string DogSound()
        {
            var animalDog = animalService.Animals().FirstOrDefault(x => x.Type == AnimalType.Dog);
            var dog = (Dog)animalDog;
            return dog.Bark();
        }

        [HttpGet]
        [Route("CatSays")]
        public string CatSays()
        {
            var animalCat = animalService.Animals().FirstOrDefault(x => x.Type == AnimalType.Cat);
            var cat = (Cat)animalCat;
            return cat.Sound;
        }

        [HttpGet]
        [Route("cowSound")]
        public string CowSoundMakes()
        {
            var animalCow = animalService.Animals().FirstOrDefault(x => x.Type == AnimalType.Cow);
            var cow = (Cow)animalCow;
            return cow.MakeSound();
        }
    }
}
