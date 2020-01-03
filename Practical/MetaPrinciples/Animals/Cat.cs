using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Animals
{
    public class Cat : Animal
    {
        public override AnimalType Type => AnimalType.Cat;

        public string Sound => "Meooooow....";
    }
}
