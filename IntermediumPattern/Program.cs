using IntermediumPattern;

AbstractMediator mediator = new Mediator();

Purchase purchase = new Purchase(mediator);
purchase.BuyIBMComputer(100);

Sale sale = new Sale(mediator);
sale.SellIBMComputer(1);

Stock stock = new Stock(mediator);
stock.ClearStock();
