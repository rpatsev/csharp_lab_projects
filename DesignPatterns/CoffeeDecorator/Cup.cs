using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeDecorator
{
    class Cup : IIngredient
    {
        public string Add()
        {
            return "A cup";
        }
    }
}
