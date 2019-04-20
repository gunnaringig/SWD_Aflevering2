using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator.User
{
    public class Widget1 : Widget
    {
        public void DoA()
        {
            Console.WriteLine("Widget 1 does A.");
            this._mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Widget 1 does B.");
            this._mediator.Notify(this, "B");
        }
    }
}
