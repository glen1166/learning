using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.DerivedClass
{
    public class AUG : Rifle
    {
        public void ZoomOut()
        {
            Console.WriteLine("通过望远镜观看...");
        }

        public override void Shoot()
        {
            Console.WriteLine("AUG射击...");
        }
    }
}
