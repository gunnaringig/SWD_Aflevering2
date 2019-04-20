using SWD_Mediator.Mediator;
using SWD_Mediator.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget1 widget1 = new Widget1();
            Widget2 widget2 = new Widget2();
            ConcreteMediator mediator = new ConcreteMediator(widget1, widget2);

            Console.WriteLine("Client triggers operation A.");
            widget1.DoA();

            Console.WriteLine("Client triggers operation D.");
            widget2.DoD();
        }
    }
}
