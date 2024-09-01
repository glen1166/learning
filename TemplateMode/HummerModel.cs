using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMode
{
    public abstract class HummerModel
    {
        public abstract void Start();
        public abstract void Stop();
        public abstract void Alarm();
        public abstract void EngineBoom();
        public abstract void Run();
    }
}
