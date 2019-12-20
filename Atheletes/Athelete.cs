using System;
using System.Collections.Generic;
using System.Text;

namespace Atheletes
{
    public enum SprintDistance
    {
        OneHundred = 100,
        TwoHundred = 200,
        FourHundred = 400
    }

    public enum SwimDistance
    {
        Fifty = 50,
        OneHundred = 100,
        TwoHundred = 200
    }
    
    public abstract class Athelete
    {
        public abstract void RunSprints(SprintDistance distance);
        public abstract void Swim(SwimDistance distance);
        public abstract void LongJump();
        public abstract void HighJump();
        public abstract void ThrowJavelin();
        public abstract void RunHurdles();
        public abstract void ThrowShotput();
        public abstract void TripleJump();
    }
}
