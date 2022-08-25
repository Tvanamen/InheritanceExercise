using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile:Animal
    {
        public string ReptileType { get; set; }
        public bool Aquatic { get; set; }
        public bool Fangs { get; set; }
        public bool Scales { get; set; }
    }
}
