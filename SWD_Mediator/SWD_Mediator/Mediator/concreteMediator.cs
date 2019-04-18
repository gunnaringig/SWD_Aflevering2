using SWD_Mediator.User;
using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator.Mediator
{
    public class ConcreteMediator : Imediator
    {
        List<IUser> user = new List<IUser>();

        public void AddParticipant(IUser User)
        {
            User.AddUser(User);
        }
        public void BroadcastMessage(string message, IUser sender)
        {
            //Missing broadcast message
        }
    }
}
