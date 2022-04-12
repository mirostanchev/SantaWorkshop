using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    public class ProductFactory : AbstractFactory
    {
        public override IProduct GetProduct(ProductType productType)
        {
            if (productType == ProductType.Bike)
            {
                return new Bike();
            }
            else if (productType == ProductType.Doll)
            {
                return new Doll();
            }

            throw new ArgumentException($"Non supported product {productType}");
        }
    }
}
