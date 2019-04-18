using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator.User
{
    public interface IUser
    {
        void sendMessage(string message);
        void AddUser(IUser user);
    }
}
