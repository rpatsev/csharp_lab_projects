using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecorator
{
    class Vanilla : Addition
    {
        public Vanilla(IIngredient ingredient) : base(ingredient)
        {
        }

        public override string Add()
        {
            return _ingredient.Add() + " and vanilla";
        }
    }
}
