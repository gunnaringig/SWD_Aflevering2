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

                Imediator mediator = new concreteMediator();
                IUser user1 = new concreteUser1(mediator);
                mediator.AddUser(user1);
                user1.SendMessage("message 1");
                Console.ReadLine();

        }
    }
}
