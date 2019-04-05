using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator
{
   public class ConcreteColleauge1(mediator mediator) : Colleague
    {
        public ConcreteColleague2(mediator mediator)

      : base(mediator)

        {

        }



        public void send(string message)

        {

            mediator.send(message, this);

        }



        public void Notify(string message)

        {

            Console.WriteLine("Colleague2 recives message: "

              + message);

        }

    }
}
}
