using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediumPattern
{
    internal class AbstractColleague
    {
        protected AbstractMediator _mediator;
        public AbstractColleague(AbstractMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
