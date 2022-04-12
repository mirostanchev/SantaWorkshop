using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    public class MagicDesk
    {
        public MagicDesk()
        {
            this.CreatedProducts = new List<IProduct>();
        }

        public List<IProduct> CreatedProducts { get; private set; }

        public void SaveCreatedProduct(IProduct product)
        {
            CreatedProducts.Add(product);
            Console.WriteLine(product.ToString());
        }
    }
}
