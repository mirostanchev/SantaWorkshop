using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop.Commands
{
    public class CommandExecutor
    {
        private readonly AbstractFactory abstractFactory;
        private readonly MagicDesk magicDesk;

        public CommandExecutor(AbstractFactory abstractFactory, MagicDesk magicDesk)
        {
            this.abstractFactory = abstractFactory;
            this.magicDesk = magicDesk;
        }

        public IProduct Execute(ProductType productType)
        {
            ICommand commandForExecution;

            if (productType == ProductType.Bike)
            {
                commandForExecution = new NeedBikesCommand(abstractFactory, magicDesk);
            }
            else if (productType == ProductType.Doll)
            {
                commandForExecution = new NeedDollsCommand(abstractFactory, magicDesk);
            }
            else
            {
                throw new ArgumentException($"Non supported product {productType}");
            }

            IProduct product = commandForExecution.Execute();
            return product;
        }
    }
}
