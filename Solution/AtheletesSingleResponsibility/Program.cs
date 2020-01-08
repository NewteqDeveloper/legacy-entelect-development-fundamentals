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
                athelete.Compete();
            }

            Console.ReadKey();
        }
    }
}
