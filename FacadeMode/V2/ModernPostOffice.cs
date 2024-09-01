using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode.V2
{
    public class ModernPostOffice
    {
        private ILetterProcess letterProcess = new LetterProcessImpl();
        private Police letterPolice = new Police();

        public void SendLetter(string context, string address)
        {
            letterProcess.WriteContext(context);
            letterProcess.FillEnvelope(address);
            letterProcess.LetterInotoEnvelope();
            letterPolice.CheckLetter(letterProcess);
            letterProcess.SendLetter();
        }
    }
}
