using Factory.DataTransferObject.Base;
using Factory.DataTransferObject.Pizzas;

namespace Factory.DataTransferObject.Factory
{
    public sealed class SimpleFactoryPizza
    {
        public Pizza CreatePizza(string type)
        {
            Pizza _pizza = null;

            if (type.ToLower() == "cheese")
                _pizza = new CheesePizza("Cheese");
            else if (type.ToLower() == "pepperoni")
                _pizza = new PepperoniPizza("Pepperoni");
            else if (type.ToLower() == "clam")
                _pizza = new ClamPizza("Clam");
            else if (type.ToLower() == "veggie")
                _pizza = new VeggiePizza("Veggie");
            return _pizza;
        }
    }
}