using System;
using System.Collections.Generic;

namespace SolidDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            var runOption = RunOptions.Shapes2;

            if (runOption == RunOptions.Shapes1)
            {
                #region shapes 1
                List<Shapes1.Shape> shapes = new List<Shapes1.Shape>
                {
                    new Shapes1.Circle(),
                    new Shapes1.Square(),
                };

                foreach (var shape in shapes)
                {
                    shape.Draw();
                }
                new Shapes1.Square().Draw();

                #endregion shapes 1
            }

            if (runOption == RunOptions.Shapes2)
            {
                #region shapes 2
                List<Shapes2.Shape> shapes2 = new List<Shapes2.Shape>
                {
                    new Shapes2.Circle(),
                    new Shapes2.Square(),
                };

                foreach (var shape in shapes2)
                {
                    Console.WriteLine($"Draw shape: {shape.Draw()}");
                }

                Console.WriteLine($"Drawing shape: {new Shapes2.Square().Draw()}");
                #endregion shapes 2
            }

            Console.ReadKey();
        }
    }
}
