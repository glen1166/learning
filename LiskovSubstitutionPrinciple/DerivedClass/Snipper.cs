using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.DerivedClass
{
    public class Snipper
    {
        public void KillEnemy(AUG aug)
        {
            aug.ZoomOut();
            aug.Shoot();
        }
    }
}
