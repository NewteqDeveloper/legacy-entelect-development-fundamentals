using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDojo.Shapes1
{
    public class Square : Shape
    {
        //public new int Draw()
        //{
        //    return 4 * 4;
        //}

        public new void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
}
