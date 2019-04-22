using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_Mediator.User;

namespace SWD_Mediator.Mediator
{
    public interface ITelephone
    {
        void Notify(object sender, string ev);
    }
}
