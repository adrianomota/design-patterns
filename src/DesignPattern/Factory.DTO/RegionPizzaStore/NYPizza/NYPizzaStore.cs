using Factory.DataTransferObject.Base;
using Factory.DataTransferObject.RegionPizzaStore.Ingredient;

namespace Factory.DataTransferObject.RegionPizzaStore.NYPizza
{
    public sealed class NYPizzaStore : SimpleFactoryPizza
    {
        protected override Base.Pizza CreatePizza(string type)
        {
            switch (type.ToLower())
            {
                case "cheese":
                    return new NYStyleCheesePizza(new NYPizzaIngredientFactory());

                case "pepperoni":
                    return new NYStylePepperoniPizza(new NYPizzaIngredientFactory());

                case "clam":
                    return new NYStyleClamPizza(new NYPizzaIngredientFactory());

                case "veggie":
                    return new NYStyleVeggiePizza(new NYPizzaIngredientFactory());

                default:
                    return null;
            }
        }
    }
}