using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecorator
{
    public abstract class Addition : IIngredient
    {
        protected IIngredient _ingredient;

        protected Addition(IIngredient ingredient)
        {
            _ingredient = ingredient;
        }
        public abstract string Add();

    }
}
