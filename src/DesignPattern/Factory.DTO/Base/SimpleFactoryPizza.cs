namespace Factory.DataTransferObject.Base
{
    public abstract class SimpleFactoryPizza
    {
        public Pizza OrderPizza(string type)
        {
            var _pizza = CreatePizza(type);
            return _pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}