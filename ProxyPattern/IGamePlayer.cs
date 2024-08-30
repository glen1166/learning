using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal interface IGamePlayer
    {
        public void Login(string user, string password);

        public void KillBoss();

        public void Upgrade();
    }
}
