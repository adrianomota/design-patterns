﻿using Factory.DataTransferObject.Base;

namespace Factory.DataTransferObject.Pizzas
{
    public sealed class CheesePizza : Pizza
    {
        public string Name { get; private set; }

        public CheesePizza(string name)
        {
            Name = name;
        }
    }
}