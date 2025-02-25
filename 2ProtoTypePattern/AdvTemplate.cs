using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ProtoTypePattern
{
    internal class AdvTemplate
    {
        private string advSubject = "XXBank of XXBank, give you a credit card, the highest limit of 100,000 yuan";
        private string advContext = "XXBank of XXBank, give you a credit card, the highest limit of 100,000 yuan";

        public string GetAdvSubject()
        {
            return this.advSubject;
        }

        public string GetAdvContext()
        {
            return this.advContext;
        }
    }
}
