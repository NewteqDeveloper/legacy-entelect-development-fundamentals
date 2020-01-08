using AtheletesSingleResponsibility.Atheletes;
using AtheletesSingleResponsibility.Data;
using System;

namespace AtheletesSingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            /* in here, the idea is to have an athelte that does EVERYTHING
             * And then they have a compete method - which will do one of many of the items listed below
             * This will be an abstract class - that contains all the methods!
             * But the athelte has all the methods of sprints, long jump, high jump etc.
             * 
             * How to make it better?
             * Then the Idea is to abstract these out to their own classes and create interface for ISprints, ILongJump, IHighJump
             * and then in each of the different classes, they extend the interfaces and then in the compete method, it uses those methods from the interface
             * 
             */

            Console.WriteLine("Hello World!");

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
        }
    }
}
