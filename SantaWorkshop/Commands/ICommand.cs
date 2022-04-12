using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop.Commands
{
    public interface ICommand
    {
        IProduct Execute();
    }
}
