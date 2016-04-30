using Factory.DataTransferObject.Base;
using Factory.DataTransferObject.Ingredients;
using Factory.DataTransferObject.RegionPizzaStore.Ingredient.Veggies;
using System.Collections.Generic;

namespace Factory.DataTransferObject.RegionPizzaStore.Ingredient
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new Dough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IList<Ingredients.Veggies> CreateVeggieses()
        {
            return new List<Ingredients.Veggies>() { new Garlic(), new Onion() };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicePepperoni();
        }

        public Clam CreateClam()
        {
            return new FreshClam();
        }
    }
}