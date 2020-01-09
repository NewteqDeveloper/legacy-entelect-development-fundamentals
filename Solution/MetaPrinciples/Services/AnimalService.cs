using MetaPrinciples.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Services
{
    public class AnimalService
    {
        private List<Animal> animals;

        public AnimalService()
        {
            animals = Database.Data.Animals.ToList();
        }

        public IList<Animal> Animals()
        {
            return animals;
        }

        public IList<Animal> AnimalOfType(AnimalType type)
        {
            return animals.Where(Database.Data.GetAnimalByTypeFunc(type)).ToList();
        }

        public string AnimalSound(AnimalType type)
        {
            var firstAnimal = animals.FirstOrDefault(Database.Data.GetAnimalByTypeFunc(type));
            if (firstAnimal == null)
            {
                return "Unknown sound";
            }
            else
            {
                return firstAnimal.Sound;
            }
        }

        public string PlayWithAnimal(int id)
        {
            var animal = animals.SingleOrDefault(x => x.Id == id);
            return animal.Play();
        }
    }
}
