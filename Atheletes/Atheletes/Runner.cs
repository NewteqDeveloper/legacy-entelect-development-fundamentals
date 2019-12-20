using System;
using System.Collections.Generic;
using System.Text;

namespace Atheletes.Atheletes
{
    public class Runner : Athelete
    {
        public override void HighJump()
        {
            throw new NotImplementedException();
        }

        public override void LongJump()
        {
            throw new NotImplementedException();
        }

        public override void RunHurdles()
        {
            Console.WriteLine($"{AtheleteInformation} Running Hurdles");
        }

        public override void RunRelay()
        {
            Console.WriteLine($"{AtheleteInformation} Running Relay");
        }

        public override void RunSprints(SprintDistance distance)
        {
            Console.WriteLine($"{AtheleteInformation} Running the sprints for: {(int)distance}m");
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
            throw new NotImplementedException();
        }
    }
}
