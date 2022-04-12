using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop.Commands
{
    public class NeedDollsCommand : ICommand
    {
        private readonly AbstractFactory abstractFactory;
        private readonly MagicDesk magicDesk;

        public NeedDollsCommand(AbstractFactory abstractFactory, MagicDesk magicDesk)
        {
            this.abstractFactory = abstractFactory;
            this.magicDesk = magicDesk;
        }

        public IProduct Execute()
        {
            IProduct doll = abstractFactory.GetProduct(ProductType.Doll);
            magicDesk.SaveCreatedProduct(doll);
            return doll;
        }
    }
}
