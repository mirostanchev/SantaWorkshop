using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    public class Bike : IProduct
    {
        public string Color { get; }

        public override string ToString()
        {
            return "Колело";
        }
    }
}
