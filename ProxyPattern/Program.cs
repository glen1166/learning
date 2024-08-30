using ProxyPattern;

IGamePlayer player = new GamePlayer("张三");
IGamePlayer proxy = new GamePlayerProxy(player);
proxy.Login("zhangsan", "password");
proxy.KillBoss();

//IGamePlayer player = new GamePlayerProxy("张三");
//player.Login("zhangsan", "password");
//player.KillBoss();

//IGamePlayer player = new GamePlayer("张三");
//player.Login("zhangsan", "password");
//player.KillBoss();

//IGamePlayer player = new GamePlayer("张三");
//IGamePlayer proxy = player.GetProxy();
//proxy.Login("zhangsan", "password");
//proxy.KillBoss();
