using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateMode
{
    public class Father
    {
        public static void Main(string[] args)
        {
            SchoolReport sr = new FouthGradeSchoolReport();
            sr.Report();
        }
    }
}
