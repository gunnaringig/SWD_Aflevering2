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

            Console.WriteLine("Choose A or B for widget 1");

            var input = Console.ReadKey();

            switch (input.Key) //Switch on Key enum
            {
                case ConsoleKey.A:
                    widget1.DoA();
                    //Console.Clear();
                    break;
                case ConsoleKey.B:
                    widget1.DoB();
                    //Console.Clear();
                    break;
            }




            Console.WriteLine("Choose C or D for widget 2");
            switch (input.Key) //Switch on Key enum
            {
                case ConsoleKey.C:
                    widget2.DoC();
                    //Console.Clear();
                    break;
                case ConsoleKey.D:
                    widget2.DoD();
                    //Console.Clear();
                    break;
            }

        }
    }
}
