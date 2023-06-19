namespace ProjectRestaurant
{
    class Beverage : Dish
    {
        private bool _cool;
        public Beverage(int dishID, string name, float price, int amount, bool cool) : base(dishID, name, price, amount)
        {
            _cool = cool;
        }
    }
}