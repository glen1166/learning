using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateMode
{
    public class FouthGradeSchoolReport : SchoolReport
    {
        public override void Report()
        {
            Console.WriteLine("尊敬的XXX家长:");
            Console.WriteLine("  ......");
            Console.WriteLine("  语文 62  数学65 体育 98  自然 63");
            Console.WriteLine("  .......");
            Console.WriteLine("               家长签名：       ");
        }

        public override void Sign(string name)
        {
            Console.WriteLine("家长签名为：" + name);
        }
    }
}
