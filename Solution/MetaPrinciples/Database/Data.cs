using MetaPrinciples.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Database
{
    public static class Data
    {

        public static IList<Animal> Animals = new List<Animal>
            {
                new Cat
                {
                    Name = "Kitty"
                },
                new Dog
                {
                    Name = "Doggo"
                },
                new Dog
                {
                    Name = "Max"
                },
                new Dog
                {
                    Name = "Billy",
                },
                new Cat
                {
                    Name = "Ginger"
                },
                new Cow
                {
                    Name = "Cowie"
                },
                new Cow
                {
                    Name = "Milky"
                },
                new Sheep
                {
                    Name = "Ba ba sheep"
                },
                new Chicken
                {
                    Name = "Chucky"
                },
                new Bird
                {
                    Name = "Tweety"
                }
            };

        public static Func<Animal, bool> GetAnimalByTypeFunc(AnimalType animalType)
        {
            return x => x.GetType().Name.Equals(animalType.ToString(), StringComparison.InvariantCultureIgnoreCase);
        }

        public static Dictionary<AnimalType, IList<Animal>> AnimalDictionary()
        {
            var animals = Animals;
            var animalDictionary = new Dictionary<AnimalType, IList<Animal>>();

            var listOfDogs = new List<Animal>();
            var listOfCats = new List<Animal>();
            var listOfCows = new List<Animal>();
            var listOfSheep = new List<Animal>();
            var listOfChickens = new List<Animal>();
            var listOfBirds = new List<Animal>();

            foreach (var animal in animals)
            {
                switch (animal)
                {
                    case Dog dog:
                        listOfDogs.Add(dog);
                        break;
                    case Cat cat:
                        listOfCats.Add(cat);
                        break;
                    case Cow cow:
                        listOfCows.Add(cow);
                        break;
                    case Sheep sheep:
                        listOfSheep.Add(sheep);
                        break;
                    case Chicken chicken:
                        listOfChickens.Add(chicken);
                        break;
                    case Bird bird:
                        listOfBirds.Add(bird);
                        break;
                }
            }

            animalDictionary.Add(AnimalType.Dog, listOfDogs);
            animalDictionary.Add(AnimalType.Cat, listOfCats);
            animalDictionary.Add(AnimalType.Cow, listOfCows);
            animalDictionary.Add(AnimalType.Chicken, listOfChickens);
            animalDictionary.Add(AnimalType.Sheep, listOfSheep);
            animalDictionary.Add(AnimalType.Bird, listOfBirds);

            return animalDictionary;
        }
    }
}
