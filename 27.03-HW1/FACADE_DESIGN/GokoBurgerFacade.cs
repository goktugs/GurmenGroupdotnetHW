namespace FACADE_DESIGN
{
    internal class GokoBurgerFacade
    {
        private readonly CheeseBurger _cheeseBurger;
        private readonly Burger _burger;

        public RestaurantFacade(CheeseBurger cheeseBurger, Burger burger)
        {
            _cheeseBurger = cheeseBurger;
            _burger = burger;
        }

        public void OrderCBurger()
        {
            _cheeseBurger.PrepareMeat();
            _cheeseBurger.GrillBuns();
            _cheeseBurger.AddCheese();
            _cheeseBurger.AddSauce();
            _cheeseBurger.Combine()
        }

        public void OrderBurger()
        {
            _cheeseBurger.PrepareMeat();
            _cheeseBurger.GrillBuns();
            _cheeseBurger.AddSauce();
            _cheeseBurger.Combine()
        }
    }
}