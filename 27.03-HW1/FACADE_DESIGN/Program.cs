using FACADE_DESIGN;

GokoBurgerFacade gokoBurgerFacade = new(new CheeseBurger(), new Burger());

gokoBurgerFacade.OrderCBurger();
Console.WriteLine("\n---------------------------------\n");
gokoBurgerFacade.OrderBurger();