using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateMode.V2
{
    public class Father
    {
        public static void Main(string[] args)
        {
            SchoolReport sr;
            sr = new FouthGradeSchoolReport();
            sr = new HighScoreDecorator(sr);
            sr = new SortDecorator(sr);
            sr.Report();
            sr.Sign("老三");
        }
    }
}
