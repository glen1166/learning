using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Soldier
    {
        private AbstractGun gun;

        public void SetGun(AbstractGun gun)
        {
            this.gun = gun;
        }

        public void KillEnemy()
        {
            Console.WriteLine("士兵开始射击...");
            gun.Shoot();
        }
    }
}
