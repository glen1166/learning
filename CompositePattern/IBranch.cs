using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal interface IBranch:ICorp
    {
        public void AddSubordinate(ICorp corp);

        public List<ICorp> GetSubordinate();
    }
}
