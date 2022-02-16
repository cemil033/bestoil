using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    public class Benzin
    {
        public double qiymet { get; set; }
        public string Marka { get; set; }
        public override string ToString()
        {
            return $"{Marka}";
        }
    }
}
