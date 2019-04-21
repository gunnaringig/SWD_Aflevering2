using SWD_Mediator.User;
using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private readonly Widget1 _concreteWidget1;
        private readonly Widget2 _concreteWidget2;

        public ConcreteMediator(Widget1 concreteWidget1, Widget2 concreteWidget2)
        {
            this._concreteWidget1 = concreteWidget1;
            this._concreteWidget1.SetMediator(this);
            this._concreteWidget2 = concreteWidget2;
            this._concreteWidget2.SetMediator(this);
        }
        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following operations:");
                this._concreteWidget2.DoC();
            }

            //if(ev == "B")
            //{
            //    Console.WriteLine("Mediator reacts on B and triggers following opertaions:");
            //    this._concreteWidget2.DoD();
            //}

            //if(ev == "C")
            //{
            //    Console.WriteLine("Mediator reacts on C and triggers the following operatoins:");
            //    this._concreteWidget1.DoA();
            //}

            if (ev == "D")
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                this._concreteWidget1.DoB();
                this._concreteWidget2.DoC();
            }
        }
    }
}
