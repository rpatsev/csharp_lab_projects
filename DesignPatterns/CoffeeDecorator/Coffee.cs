using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecorator
{
    public class Coffee : Addition
    {
        public Coffee(IIngredient ingredient) 
            : base(ingredient)
        {

        }

        public override string Add()
        {
            return _ingredient.Add() + ", coffee";
        }
    }
}
