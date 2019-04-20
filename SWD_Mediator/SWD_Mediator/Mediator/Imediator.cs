using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_Mediator.User;

namespace SWD_Mediator.Mediator
{
    public interface IMediator
    {
        void AddUser(IUser user);
        void Broadcast(string message, IUser sender);
        //void Broadcast(string message, ConcreteUser1 concreteUser1);
    }
}
