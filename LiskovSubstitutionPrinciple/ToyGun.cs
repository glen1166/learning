using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class ToyGun : AbstractToy
    {
        public override void Play()
        {
            Console.WriteLine("玩具枪...");
        }
    }
}
