using SWD_Mediator.Mediator;
using SWD_Mediator.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SWD_Mediator
{

    class Program
    {
        static void Main(string[] args)
        {
            Widget1 widget1 = new Widget1();
            Widget2 widget2 = new Widget2();
            ConcreteMediator mediator = new ConcreteMediator(widget1, widget2);

            Console.WriteLine("Choose operation A, B, C or D");

            var input = Console.ReadKey();

            switch (input.Key) //Switch on Key enum
            {
                case ConsoleKey.A:
                    Console.Clear();
                    widget1.DoA();
                    break;
                case ConsoleKey.B:
                    Console.Clear();
                    widget1.DoB();
                    break;
            
                case ConsoleKey.C:
                    Console.Clear();
                    widget2.DoC();
                    break;
                case ConsoleKey.D:
                    Console.Clear();
                    widget2.DoD();
                    break;
            }

        }
    }
}
