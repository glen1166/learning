using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    public interface ILetterProcess
    {
        public void WriteContext(string context);

        public void FillEnvelope(string address);

        public void LetterInotoEnvelope();

        public void SendLetter();
    }
}
