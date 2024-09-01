using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class MachineGun : AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("机枪射击...");
        }
    }
}
