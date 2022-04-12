using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop.Commands
{
    public class NeedBikesCommand : ICommand
    {
        private readonly AbstractFactory abstractFactory;
        private readonly MagicDesk magicDesk;

        public NeedBikesCommand(AbstractFactory abstractFactory, MagicDesk magicDesk)
        {
            this.abstractFactory = abstractFactory;
            this.magicDesk = magicDesk;
        }

        public IProduct Execute()
        {
            IProduct bike = abstractFactory.GetProduct(ProductType.Bike);
            magicDesk.SaveCreatedProduct(bike);
            return bike;
        }
    }
}
