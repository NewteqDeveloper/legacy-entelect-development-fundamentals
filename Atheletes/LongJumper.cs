using System;
using System.Collections.Generic;
using System.Text;

namespace Atheletes
{
    public class LongJumper : Athelete
    {
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
            throw new NotImplementedException();
        }
    }
}
