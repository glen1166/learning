using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class AbstractToy
    {
        public AbstractGun gun;

        public void SetGun(AbstractGun gun)
        {
            this.gun = gun;
        }

        public abstract void Play();
    }
}
