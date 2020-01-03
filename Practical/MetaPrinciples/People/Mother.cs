using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.People
{
    public class Mother : Person
    {
        public Mother mother { get; set; }
        public Father father { get; set; }
        public IList<Child> children { get; set; }

        public Father FindFather()
        {
            return father;
        }

        public Mother FindMother()
        {
            return mother;
        }

        public Child FindChild(int number)
        {
            return children[number];
        }

        public Father FindChildFather(int number)
        {
            return children[number].father;
        }

        public Mother FindChildGrandMother(int number)
        {
            return children[number].mother.mother;
        }

        public Mother FindChildGreatGrandMother(int number)
        {
            return children[number].mother.mother.mother;
        }
    }
}
