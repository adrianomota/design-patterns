using Factory.DataTransferObject.Ingredients;
using System.Collections.Generic;

namespace Factory.DataTransferObject.Base
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();

        Sauce CreateSauce();

        Cheese CreateCheese();

        IList<Veggies> CreateVeggieses();

        Pepperoni CreatePepperoni();

        Clam CreateClam();
    }
}