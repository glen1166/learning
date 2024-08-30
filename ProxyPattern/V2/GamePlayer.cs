using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.V2
{
    internal class GamePlayer : IGamePlayer
    {
        private string _name;
        //构造函数限制谁能创建对象，并同时传递姓名
        public GamePlayer(IGamePlayer _gamePlayer, string name)
        {
            if(_gamePlayer == null)
            {
                throw new Exception("不能创建真实角色！");
            }
            else
            {
                this._name = name;
            }
        }

        public void Login(string user, string password)
        {
            Console.WriteLine("登录名为" + user + "的用户" + this._name + "登录成功！");
        }

        public void KillBoss()
        {
            Console.WriteLine(this._name + "在打怪！");
        }

        public void Upgrade()
        {
            Console.WriteLine(this._name + "又升了一级！");
        }
    }
}
