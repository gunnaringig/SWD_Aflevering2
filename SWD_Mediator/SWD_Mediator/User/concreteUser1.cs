using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator.User
{
    public class ConcreteUser1 : IUser
    {
        protected IMediator Mediator;
        public ConcreteUser1(IMediator mediator)
        {
            this.Mediator = mediator;
        }
        public void SendMessage(string message)
        {
            Mediator.Broadcast(message, this);
        }

        public void AddUser(IUser user)
        {

        }
    }
}
