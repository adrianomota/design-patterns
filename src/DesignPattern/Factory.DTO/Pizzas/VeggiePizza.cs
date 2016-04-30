using Factory.DataTransferObject.Base;

namespace Factory.DataTransferObject.Pizzas
{
    public sealed class VeggiePizza : Pizza
    {
        public string Name { get; private set; }

        public VeggiePizza(string name)
        {
            Name = name;
        }
    }
}