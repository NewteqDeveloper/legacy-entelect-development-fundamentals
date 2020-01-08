using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDojoLiskov.Shapes1
{
    
    public abstract class Shape
    {
        public virtual string Draw()
        {
            return "Unknown shape";
        }
    }
}
