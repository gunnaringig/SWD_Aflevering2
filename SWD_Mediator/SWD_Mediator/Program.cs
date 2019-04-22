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
            Lala myLala = new Lala();
            Po myPo = new Po();
            ConcreteMediator mediator = new ConcreteMediator(myLala, myPo);

            Console.WriteLine("Clint asks Lala to dance");
            myLala.Dance();

            //Console.WriteLine("Client triggers operation D.");
            //myPo.DoD();
        }
    }
}
