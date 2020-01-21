using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDojoLiskov.Shapes
{
    public class Square : Shape
    {
        public override object Draw()
        {
            return 4 * 4;
        }
    }
}
