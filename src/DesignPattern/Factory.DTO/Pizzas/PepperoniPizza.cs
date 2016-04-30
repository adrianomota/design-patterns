﻿using Factory.DataTransferObject.Base;

namespace Factory.DataTransferObject.Pizzas
{
    public sealed class PepperoniPizza : Pizza
    {
        public string Name { get; private set; }

        public PepperoniPizza(string name)
        {
            Name = name;
        }
    }
}