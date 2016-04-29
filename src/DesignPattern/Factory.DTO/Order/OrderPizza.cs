using Factory.DataTransferObject.Base;

namespace Factory.DataTransferObject.Order
{
    public sealed class OrderPizza
    {
        private Pizza _pizza;

        public Pizza GetOrderPizza(string type)
        {

            return _pizza;
        }
    }
}