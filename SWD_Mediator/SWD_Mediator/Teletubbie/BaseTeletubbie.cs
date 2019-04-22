using SWD_Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator.Teletubbie
{
    public abstract class BaseTeletubbie
    {
        protected ITelephone _telephone;

        protected BaseTeletubbie(ITelephone telephone = null)
        {
            this._telephone = telephone;
        }

        public void SetMediator(ITelephone telephone)
        {
            this._telephone = telephone;
        }
    }
}
