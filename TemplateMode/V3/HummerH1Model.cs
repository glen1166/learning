using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMode.V3
{
    public class HummerH1Model : HummerModel
    {
        private bool isAlarm = true;

        protected override void Start()
        {
            Console.WriteLine("悍马H1发动...");
        }

        protected override void Stop()
        {
            Console.WriteLine("悍马H1停车...");
        }

        protected override void Alarm()
        {
            Console.WriteLine("悍马H1鸣笛...");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("悍马H1引擎声音是这样的...");
        }

        protected override bool IsAlarm()
        {
            return this.isAlarm;
        }

        public void SetAlarm(bool isAlarm)
        {
            this.isAlarm = isAlarm;
        }
    }
}
