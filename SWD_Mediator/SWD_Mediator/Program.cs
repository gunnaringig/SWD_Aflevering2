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
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleagueA cA = new ConcreteColleagueA(mediator);
            ConcreteColleagueB cB = new ConcreteColleagueB(mediator);

            mediator.ConcreteColleagueA = cA;
            mediator.ConcreteColleagueB = cB;

            cA.send("testing");
            cB.send("responding to testing");

            Console.ReadKey();
        }
    }
}
