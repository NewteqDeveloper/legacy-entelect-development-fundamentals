using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDojoLiskov.Shapes2
{
    public class Square : Shape
    {
        public new int Draw()
        {
            return 4 * 4;
        }
    }
}
