using System;
using System.Collections.Generic;
using System.Text;

namespace Atheletes.Atheletes
{
    public class HighJumper : Athelete
    {
        public override void HighJump()
        {
            Console.WriteLine($"{AtheleteInformation} doing a SUPPPPPPPPPER HIGH jump");
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
