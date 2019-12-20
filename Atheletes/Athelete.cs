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

    public enum Gender
    {
        Male,
        Female
    }
    
    public abstract class Athelete
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public Gender Gender { get; set; }

        public string AtheleteInformation => $"{FirstName} {LastName} ({Gender}), from {Country} is now performing :: ";
        
        public abstract void RunSprints(SprintDistance distance);
        public abstract void Swim(SwimDistance distance);
        public abstract void LongJump();
        public abstract void HighJump();
        public abstract void ThrowJavelin();
        public abstract void RunHurdles();
        public abstract void RunRelay();
        public abstract void ThrowShotput();
        public abstract void TripleJump();
    }
}
