using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMode
{
    public class HummerH2Model : HummerModel
    {
        public override void Start()
        {
            Console.WriteLine("悍马H2发动...");
        }

        public override void Stop()
        {
            Console.WriteLine("悍马H2停车...");
        }

        public override void Alarm()
        {
            Console.WriteLine("悍马H2鸣笛...");
        }

        public override void EngineBoom()
        {
            Console.WriteLine("悍马H2引擎声音是这样的...");
        }

        public override void Run()
        {
            this.Start();
            this.EngineBoom();
            this.Alarm();
            this.Stop();
        }
    }
}
