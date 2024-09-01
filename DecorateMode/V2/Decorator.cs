using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateMode.V2
{
    public abstract class Decorator : SchoolReport
    {
        private SchoolReport sr;

        public Decorator(SchoolReport sr)
        {
            this.sr = sr;
        }

        public override void Report()
        {
            this.sr.Report();
        }

        public override void Sign(string name)
        {
            this.sr.Sign(name);
        }
    }
}
