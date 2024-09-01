using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMode.V2
{
    public class HummerH1Model : HummerModel
    {
        public override void Start()
        {
            Console.WriteLine("悍马H1发动...");
        }

        public override void Stop()
        {
            Console.WriteLine("悍马H1停车...");
        }

        public override void Alarm()
        {
            Console.WriteLine("悍马H1鸣笛...");
        }

        public override void EngineBoom()
        {
            Console.WriteLine("悍马H1引擎声音是这样的...");
        }
    }
}
