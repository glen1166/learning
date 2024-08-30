using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.V3
{
    internal class GamePlayer : IGamePlayer
    {
        private string _name;
        private IGamePlayer? proxy;

        public GamePlayer(string name)
        {
            this._name = name;
        }

        public void KillBoss()
        {
            if (this.IsProxy())
            {
                Console.WriteLine(this._name + " is killing boss");
            }
            else
            {
                Console.WriteLine("Please use proxy");
            }
        }

        public void Login(string user, string password)
        {
            if (this.IsProxy())
            {
                Console.WriteLine("Login name: " + user + " with password: " + password);
            }
            else
            {
                Console.WriteLine("Please use proxy");
            }
        }

        public void Upgrade()
        {
            if (this.IsProxy())
            {
                Console.WriteLine(this._name + " is upgrading");
            }
            else
            {
                Console.WriteLine("Please use proxy");
            }
        }

        public IGamePlayer GetProxy()
        {
            this.proxy = new GamePlayerProxy(this);
            return this.proxy;
        }

        private bool IsProxy()
        {
            return this.proxy != null;
        }
    }
}
