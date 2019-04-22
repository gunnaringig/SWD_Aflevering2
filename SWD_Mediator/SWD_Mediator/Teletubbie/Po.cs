using System;
using SWD_Mediator.Teletubbie;

namespace SWD_Mediator.User
{
    public class Po : BaseTeletubbie
    {
        public void Clap()
        {
            Console.WriteLine("Po starts clapping");
            this._telephone.Notify(this, "Clapping");
        }

        public void DoD() // bliver ikke brugt lige nu
        {
            Console.WriteLine("Widget 2 does D.");
            this._telephone.Notify(this, "D");
        }
    }
}