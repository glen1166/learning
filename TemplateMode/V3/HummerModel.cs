using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMode.V3
{
    public abstract class HummerModel
    {
        protected abstract  void Start();
        protected abstract  void Stop();

        protected abstract  void Alarm();
        protected abstract  void EngineBoom();

        public virtual void Run()
        {
            this.Start();
            this.EngineBoom();

            if (this.IsAlarm())
            {
                this.Alarm();
            }

            this.Stop();
        }

        protected virtual bool IsAlarm()
        {
            return true;
        }
    }
}
