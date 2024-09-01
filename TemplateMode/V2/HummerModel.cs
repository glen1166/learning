using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMode.V2
{
    public abstract class HummerModel
    {
        public abstract void Start();
        public abstract void Stop();
        public abstract void Alarm();
        public abstract void EngineBoom();
        public  void Run()
        {
            this.Start();
            this.EngineBoom();
            this.Alarm();
            this.Stop();
        }
    }
}
