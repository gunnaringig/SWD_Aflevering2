using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator
{
   abstract class mediator
    {
        public abstract void send(string message, Colleague colleague);
    }
}
