using Factory.DataTransferObject.Base;

namespace Factory.DataTransferObject.Pizzas
{
    public sealed class ClamPizza : Pizza
    {
        public string Name { get; private set; }

        public ClamPizza(string name)
        {
            Name = name;
        }
    }
}