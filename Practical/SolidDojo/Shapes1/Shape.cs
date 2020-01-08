using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDojo.Shapes1
{
    
    public abstract class Shape
    {
        public virtual string Draw()
        {
            return "Unknown shape";
        }
    }
}
