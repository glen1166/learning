using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FlyweightPattern
{
    internal class SignInfoFactory
    {
        private static Dictionary<string, SignInfo> _pool = new Dictionary<string, SignInfo>();

        public static SignInfo GetSignInfo(string key)
        {
            SignInfo result;
            if (!_pool.ContainsKey(key))
            {
                Console.WriteLine(key + "----建立对象，并放置到池中");
                result = new SignInfo4Pool(key);
                _pool.Add(key, result);
            }
            else
            {
                result = _pool[key];
                Console.WriteLine(key + "----直接从池中取得");
            }
            return result;
        }
    }
}
