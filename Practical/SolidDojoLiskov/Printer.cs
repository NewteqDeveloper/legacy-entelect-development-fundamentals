using SolidDojoLiskov.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDojoLiskov
{
    public class Printer
    {
        public void PrintShape(Shape shape)
        {
            var result = shape.Draw();
            if (result.GetType() == typeof(string))
            {
                Console.WriteLine(result);
            }
            else
            {
                throw new Exception("Invalid data sent to printer");
            }
        }
    }
}
