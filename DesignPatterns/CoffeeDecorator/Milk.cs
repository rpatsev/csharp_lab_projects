using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecorator
{
    public class Milk : Addition
    {
        public Milk(IIngredient ingredient) : base(ingredient)
        {
        }

        public override string Add()
        {
            return _ingredient.Add() + " with milk";
        }
    }
}
