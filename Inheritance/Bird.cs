using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird:Animal
    {
        public string TypeOfBird { get; set; }
        public bool Flies { get; set; }
        public int WingSpan { get; set; }   
        public string FeatherColor { get; set; }
    }
}
