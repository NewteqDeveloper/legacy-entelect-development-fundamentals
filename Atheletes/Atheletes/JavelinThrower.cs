using System;
using System.Collections.Generic;
using System.Text;

namespace Atheletes.Atheletes
{
    public class JavelinThrower : Athelete
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
            Console.WriteLine($"{AtheleteInformation} - throwing the javelin!");
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
