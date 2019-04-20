using System;

namespace SWD_Mediator.User
{
    public class Widget2 : Widget
    {
        public void DoC()
        {
            Console.WriteLine("Widget 2 does C.");
            this._mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Widget 2 does D.");
            this._mediator.Notify(this, "D");
        }
    }
}