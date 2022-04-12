using SantaWorkshop.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    public class Midget : IObserver
    {
        private readonly CommandExecutor commandExecutor;

        public Midget(CommandExecutor commandExecutor)
        {
            this.commandExecutor = commandExecutor;
        }

        public void Update(IObservable observable)
        {
            if (observable is SantaClaus santaClaus)
            {
                ProductType productToCreate = santaClaus.LatestProduct;
                commandExecutor.Execute(productToCreate);
            }
        }
    }
}
