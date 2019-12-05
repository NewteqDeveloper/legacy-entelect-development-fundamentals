using System;
using System.Collections.Generic;

namespace SolidDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(),
                new Square(),
            };
            
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
            new Square().Draw();

            Console.ReadKey();
        }
    }
}
