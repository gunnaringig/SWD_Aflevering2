using SWD_Mediator.User;
using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator.Mediator
{
    public class ConcreteMediator : IMediator
    {
        List<IUser> user = new List<IUser>();

        public void AddUser(IUser user)
        {
            user.AddUser(user);
        }
        public void Broadcast(string message, IUser sender)
        {
            Console.WriteLine(message);
            //Missing broadcast message
        }

        //public void Broadcast(string message, ConcreteUser1 concreteUser1)
        //{

        //}
    }
}
