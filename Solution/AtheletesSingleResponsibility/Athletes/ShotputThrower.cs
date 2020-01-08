using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class ShotputThrower : Athlete, IShotputThrow
    {
        public ShotputThrower(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void Compete()
        {
            this.ThrowShotput();
        }

        public void ThrowShotput()
        {
            Console.WriteLine($"{AtheleteInformation} - throwing the shotput (this thing is heavy!)");
        }
    }
}
