using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_Mediator.User;

namespace SWD_Mediator.Mediator
{
    public interface Imediator
    {
        void AddUser(IUser User);
        void Broadcast(string message, IUser sender);
        void Broadcast(string message, concreteUser1 concreteUser1);
    }
}
