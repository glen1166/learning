using StrategyPattern;

Context context = new Context(new BackDoor());
context.Operate();

context = new Context(new GiveGreenLight());
context.Operate();

context = new Context(new BlockEnemy());
context.Operate();
