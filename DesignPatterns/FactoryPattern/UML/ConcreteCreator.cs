using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConcreteCreator : Creator
    {
        public Product FactoryMethod(int index)
        {
            switch (index)
            {
                case 0:
                    return new ConcreteProduct();
                case 1:
                    return new ConcreteProductB();
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
