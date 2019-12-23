using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDojo.Shapes1
{
    
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Unknown shape");
        }
    }
}
