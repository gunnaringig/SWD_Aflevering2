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

                IMediator mediator = new ConcreteMediator();
                IUser user1 = new ConcreteUser1(mediator);
                mediator.AddUser(user1);
                user1.SendMessage("message 1");
                Console.ReadLine();

        }
    }
}
