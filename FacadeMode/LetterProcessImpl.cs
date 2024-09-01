using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    public class LetterProcessImpl : ILetterProcess
    {
        public void WriteContext(string context)
        {
            Console.WriteLine("填写信的内容..." + context);
        }

        public void FillEnvelope(string address)
        {
            Console.WriteLine("填写收件人地址及姓名..." + address);
        }

        public void LetterInotoEnvelope()
        {
            Console.WriteLine("把信放到信封中...");
        }

        public void SendLetter()
        {
            Console.WriteLine("邮递信件...");
        }
    }
}
