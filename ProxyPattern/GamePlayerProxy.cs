using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class GamePlayerProxy : IGamePlayer
    {
        private IGamePlayer _gamePlayer;
        public GamePlayerProxy(IGamePlayer gamePlayer)
        {
            this._gamePlayer = gamePlayer;
        }

        public void KillBoss()
        {
            this._gamePlayer.KillBoss();
        }

        public void Login(string user, string password)
        {
            this._gamePlayer.Login(user, password);
        }

        public void Upgrade()
        {
            this._gamePlayer.Upgrade();
        }
    }
}
