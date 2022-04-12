using SantaWorkshop.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SantaClaus santaClaus = new SantaClaus();

            AbstractFactory productFactory = new ProductFactory();
            MagicDesk magicDesk = new MagicDesk();  
            CommandExecutor commandExecutor = new CommandExecutor(productFactory, magicDesk);
            IObserver midget1 = new Midget(commandExecutor);

            santaClaus.Subscribe(midget1);
            santaClaus.WantsBike();
            santaClaus.WantsDoll();
        }
    }
}
