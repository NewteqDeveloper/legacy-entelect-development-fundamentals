using System;
using System.Collections.Generic;

namespace SolidDojo
{
    class Program
    {
        // THIS PROGRAM IS TO SHOW THE LISKOV SUBSTITUTION PRINCPLE BROKEN with the use of the new keyword
        // This is just for demonostration purposes

        static void Main(string[] args)
        {
            var runOption = RunOptions.ShapesNewOverrideInt;

            if (runOption == RunOptions.ShapesNewOverride)
            {
                #region ShapesNewOverride
                List<Shapes1.Shape> shapes = new List<Shapes1.Shape>
                {
                    new Shapes1.Circle(),
                    new Shapes1.Square(),
                };

                Console.WriteLine("Polymorphic Draw:");
                foreach (var shape in shapes)
                {
                    Console.WriteLine($"Shape: {shape.GetType().Name} -- {shape.Draw()}");
                }
                Console.WriteLine("==============================");
                Console.WriteLine("new Square Draw:");
                Console.WriteLine(new Shapes1.Square().Draw());

                #endregion ShapesNewOverride
            }

            // MOST EXTREME CASE - because draw does not do at all what the base class does
            if (runOption == RunOptions.ShapesNewOverrideInt)
            {
                #region ShapesNewOverrideInt
                List<Shapes2.Shape> shapes2 = new List<Shapes2.Shape>
                {
                    new Shapes2.Circle(),
                    new Shapes2.Square(),
                };

                Console.WriteLine("Polymorphic Draw:");
                foreach (var shape in shapes2)
                {
                    Console.WriteLine($"Draw shape: {shape.GetType().Name} -- {shape.Draw()}");
                }
                Console.WriteLine("==============================");
                Console.WriteLine("new Square Draw:");
                Console.WriteLine(new Shapes2.Square().Draw());
                #endregion ShapesNewOverrideInt
            }

            Console.ReadKey();
        }
    }
}
