using FACADE_DESIGN;

GokoBurgerFacade gokoBurgerFacade = new(new CBurger(), new Burger());

gokoBurgerFacade.OrderCBurger();
Console.WriteLine("\n---------------------------------\n");
gokoBurgerFacade.OrderBurger();