using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class LiftState
    {
        protected Context context;

        public void SetContext(Context context)
        {
            this.context = context;
        }

        public abstract void Open();
        public abstract void Close();
        public abstract void Run();
        public abstract void Stop();
    }
}
