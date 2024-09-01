using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateMode
{
    /// <summary>
    /// 这种扩展方式是不建议的。
    /// </summary>
    public class SugarFouthGradeSchoolReport : FouthGradeSchoolReport
    {
        private void ReportHighScore()
        {
            Console.WriteLine("这次考试语文最高是75，数学是78，自然是80");
        }

        private void ReportSort()
        {
            Console.WriteLine("我是排名第38名");
        }

        public override void Report()
        {
            this.ReportHighScore();
            base.Report();
            this.ReportSort();
        }
    }
}
