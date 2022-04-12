using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    public abstract class AbstractFactory
    {
        public abstract IProduct GetProduct(ProductType productType);
    }
}
