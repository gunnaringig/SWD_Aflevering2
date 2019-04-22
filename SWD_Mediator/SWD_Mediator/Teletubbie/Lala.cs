using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_Mediator.Teletubbie;

namespace SWD_Mediator.User
{
    public class Lala : BaseTeletubbie
    {
        public void Dance()
        {
            Console.WriteLine("Lala dancers");
            this._telephone.Notify(this, "Dance");
        }

        public void Sit() // bliver ikke brugt lige nu
        {
            Console.WriteLine("Lala sits");
            this._telephone.Notify(this, "Sits");
        }
    }
}
