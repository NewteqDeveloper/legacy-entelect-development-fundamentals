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
        private readonly AnimalService animalService;

        public FarmController()
        {
            this.animalService = new AnimalService();

            // things to do for this practical still:
            /*
             * new up the animal service rather - let them DI it in
             * 
             * Add a report endpoint
             * 
             * The solution will be to do a typeof(Dog) check on the classes in the list
             */
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

        [HttpGet]
        [Route("howManyDogs")]
        public string HowManyDogs()
        {
            return animalService.ReportOfDogs();
        }

        [HttpGet]
        [Route("NumberofCats")]
        public IActionResult NoCats()
        {
            return Ok(animalService.ReportOfCats());
        }
    }
}
