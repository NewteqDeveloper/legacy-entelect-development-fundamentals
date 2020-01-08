using AtheletesSingleResponsibility.Athletes;
using AtheletesSingleResponsibility.Data;
using System;

namespace AtheletesSingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var athelete in Database.Atheletes)
            {
                if(athelete.GetType() == typeof(HighJumper))
                {
                    athelete.HighJump();
                }

                if (athelete.GetType() == typeof(JavelinThrower))
                {
                    athelete.ThrowJavelin();
                }

                if (athelete.GetType() == typeof(LongJumper))
                {
                    athelete.LongJump();
                    athelete.TripleJump();
                }

                if (athelete.GetType() == typeof(Runner))
                {
                    athelete.RunSprints(SprintDistance.OneHundred);
                    athelete.RunRelay();
                    athelete.RunHurdles();
                    athelete.ThrowJavelin();
                }

                if (athelete.GetType() == typeof(ShotputThrower))
                {
                    athelete.ThrowShotput();
                    athelete.ThrowJavelin();
                }

                if (athelete.GetType() == typeof(Swimmer))
                {
                    athelete.Swim(SwimDistance.OneHundred);
                }
            }

            Console.ReadKey();
        }
    }
}
