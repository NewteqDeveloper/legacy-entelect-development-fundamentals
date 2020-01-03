using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.People
{
    public class Father : Person
    {
        public Mother mother { get; set; }
        public Father father { get; set; }
        public IList<Child> children { get; set; }
    }
}
