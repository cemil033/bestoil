using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    public class Food
    {
        public string Name { get; set; }
        public double qiymet { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
