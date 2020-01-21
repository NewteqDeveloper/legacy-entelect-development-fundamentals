using SolidDojoLiskov.Shapes;
using System;
using System.Collections.Generic;

namespace SolidDojoLiskov
{
    class Program
    {
        /*
         * This example is extremely silly, but it demonostrates the behaviour of breaking LISKOV
         */

        static void Main(string[] args)
        {
            var printer = new Printer();

            List<Shape> shapes = new List<Shape>
                {
                    new Circle(),
                    new Square(),
                };

            Console.WriteLine("Polymorphic Draw:");
            foreach (var shape in shapes)
            {
                printer.PrintShape(shape);
            }

            Console.ReadKey();
        }
    }
}
