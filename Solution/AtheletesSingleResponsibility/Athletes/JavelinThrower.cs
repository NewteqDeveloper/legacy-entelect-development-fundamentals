using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class JavelinThrower : Athlete, IJavelinThrow
    {
        public JavelinThrower(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void Compete()
        {
            this.ThrowJavelin();
        }

        public void ThrowJavelin()
        {
            Console.WriteLine($"{AtheleteInformation} - throwing the javelin!");
        }
    }
}
