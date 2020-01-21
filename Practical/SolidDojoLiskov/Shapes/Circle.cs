using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDojoLiskov.Shapes
{
    public class Circle : Shape
    {
        public override object Draw()
        {
            return "Drawing Circle";
        }
    }
}
