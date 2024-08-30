using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class GamePlayer : IGamePlayer
    {
        private string _name;
        public GamePlayer(string name)
        {
            this._name = name;
        }

        public void Login(string user, string password)
        {
            Console.WriteLine("登录名为{0}的用户{1}登录成功", user, this._name);
        }

        public void KillBoss()
        {
            Console.WriteLine("{0}在打怪", this._name);
        }

        public void Upgrade()
        {
            Console.WriteLine("{0}又升了一级", this._name);
        }
    }
}
