using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Atheletes
{
    public class LongJumper : Athelete
    {
        public LongJumper(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void HighJump()
        {
            throw new NotImplementedException();
        }

        public override void LongJump()
        {
            Console.WriteLine($"{AtheleteInformation} Performing loooooooooong jump");
        }

        public override void RunHurdles()
        {
            throw new NotImplementedException();
        }

        public override void RunRelay()
        {
            throw new NotImplementedException();
        }

        public override void RunSprints(SprintDistance distance)
        {
            throw new NotImplementedException();
        }

        public override void Swim(SwimDistance distance)
        {
            throw new NotImplementedException();
        }

        public override void ThrowJavelin()
        {
            throw new NotImplementedException();
        }

        public override void ThrowShotput()
        {
            throw new NotImplementedException();
        }

        public override void TripleJump()
        {
            Console.WriteLine($"{AtheleteInformation} Performing 1 long jump, 2 longer jump, and 3 LOOOOOONG jump");
        }
    }
}
