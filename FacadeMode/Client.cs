using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    public class Client
    {
        public static void Main(string[] args)
        {
            ILetterProcess letterProcess = new LetterProcessImpl();
            letterProcess.WriteContext("Hello, It's me, Mario!");
            letterProcess.FillEnvelope("Mario");
            letterProcess.LetterInotoEnvelope();
            letterProcess.SendLetter();
        }
    }
}
