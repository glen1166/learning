using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FlyweightPattern
{
    internal class SignInfo4Pool : SignInfo
    {
        private string? _key;
        public SignInfo4Pool(string key)
        {
            this._key = key;
        }
        public string? GetKey()
        {
            return this._key;
        }
    }
}
}
