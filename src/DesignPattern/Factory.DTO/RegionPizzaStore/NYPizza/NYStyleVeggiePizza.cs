using Factory.DataTransferObject.Base;
using Factory.DataTransferObject.Ingredients;
using System;
using System.Collections.Generic;

namespace Factory.DataTransferObject.RegionPizzaStore.NYPizza
{
    public class NYStyleVeggiePizza : Base.Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public string Name { get; private set; }

        public Dough Dough { get; private set; }
        public Sauce Sauce { get; private set; }
        public IList<Veggies> Veggieses { get; set; }
        public Cheese Cheese { get; private set; }
        public Pepperoni Pepperoni { get; private set; }
        public Clam Clam { get; private set; }

        public NYStyleVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing... {0}", Name);

            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Veggieses = _pizzaIngredientFactory.CreateVeggieses();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Pepperoni = _pizzaIngredientFactory.CreatePepperoni();
            Clam = _pizzaIngredientFactory.CreateClam();
        }
    }
}