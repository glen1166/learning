using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMode.V3
{
    public class HummerH2Model : HummerModel
    {
        protected override void Start()
        {
            Console.WriteLine("悍马H2发动...");
        }

        protected override void Stop()
        {
            Console.WriteLine("悍马H2停车...");
        }

        protected override void Alarm()
        {
            Console.WriteLine("悍马H2鸣笛...");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("悍马H2引擎声音是这样的...");
        }

        protected override bool IsAlarm()
        {
            return false;
        }
    }
}
