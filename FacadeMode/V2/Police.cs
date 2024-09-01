using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode.V2
{
    public class Police
    {
        public void CheckLetter(ILetterProcess letterProcess)
        {
            Console.WriteLine("检查信件");
        }
    }
}
