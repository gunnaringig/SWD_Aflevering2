using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator
{
   abstract class Colleague
    {  
    protected mediator mediator;

        public Colleague(mediator mediator)

        {
            this.mediator = mediator;
        }

    }
}

