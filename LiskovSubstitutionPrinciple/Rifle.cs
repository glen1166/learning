using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Rifle : AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("步枪射击...");
        }
    }
}
