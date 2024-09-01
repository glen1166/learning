using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateMode.V2
{
    public class HighScoreDecorator : Decorator
    {
        public HighScoreDecorator(SchoolReport sr) : base(sr)
        {
        }

        private void ReportHighScore()
        {
            Console.WriteLine("这次考试语文最高是75，数学是78，自然是80");
        }

        public override void Report()
        {
            this.ReportHighScore();
            base.Report();
        }
    }
}
