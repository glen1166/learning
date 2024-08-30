// See https://aka.ms/new-console-template for more information
using BridgeMode;
using BridgeMode.V2;


//HouseCorp houseCorp = new HouseCorp();
//houseCorp.MakeMoney();

//ClothersCorp clothersCorp = new ClothersCorp();
//clothersCorp.MakeMoney();


//V2
House house = new House();
BridgeMode.V2.HouseCorp houseCorp = new BridgeMode.V2.HouseCorp(house);
houseCorp.MakeMoney();

ShanZhaiCorp shanZhaiCorp = new ShanZhaiCorp(new Clothes());
shanZhaiCorp.MakeMoney();
