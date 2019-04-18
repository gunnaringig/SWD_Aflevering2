using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator.User
{
    public class concreteUser1 : IUser
    {
        protected Imediator mediator;
        public concreteUser1(Imediator mediator)
        {
            this.mediator = mediator;
        }
        public void sendMessage(string message)
        {
            mediator.Broadcast(message, this);
        }
    }
}
