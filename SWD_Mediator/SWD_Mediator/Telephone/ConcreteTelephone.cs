using SWD_Mediator.Teletubbie;
using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_Mediator.User;

namespace SWD_Mediator.Mediator
{
    public class ConcreteMediator : ITelephone
    {
        private readonly Lala _lala;
        private readonly Po _po;

        public ConcreteMediator(Lala lala, Po po)
        {
            this._lala = lala;
            this._lala.SetMediator(this);
            this._po = po;
            this._po.SetMediator(this);
        }
        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "Dance":
                Console.WriteLine("Telephone watches Lala's dance, and tells Po to clap");
                this._po.Clap();
                break;

                case "Clapping":
                Console.WriteLine("Telephone watches Po clapping");
                break;

            }
        }
    }
}
