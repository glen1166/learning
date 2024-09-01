using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorateMode.V2
{
    public class SortDecorator: Decorator
    {
        public SortDecorator(SchoolReport sr) : base(sr)
        {
        }

        private void ReportSort()
        {
            Console.WriteLine("我是排名第38名...");
        }

        public override void Report()
        {
            base.Report();
            this.ReportSort();
        }
    }
}
