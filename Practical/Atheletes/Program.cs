using System;

namespace Atheletes
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
        }
    }
}
