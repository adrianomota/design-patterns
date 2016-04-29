using Factory.DataTransferObject.Base;
using Factory.DataTransferObject.Factory;

namespace Factory.DataTransferObject.PizzaStore
{
    public sealed class PizzaStore
    {
        private readonly SimpleFactoryPizza _simpleFactoryPizza;

        public PizzaStore(SimpleFactoryPizza simpleFactoryPizza)
        {
            _simpleFactoryPizza = simpleFactoryPizza;
        }

        public Pizza OrderPizza(string type)
        {
            var _pizza = _simpleFactoryPizza.CreatePizza(type);

            _pizza.Prepare();
            _pizza.Bake();
            _pizza.Cut();
            _pizza.Box();

            return _pizza;
        }
    }
}