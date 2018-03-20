using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.Countries
{
    public abstract class Country : ICountry
    {
        public virtual Currency Currency { get { return Currency.EUR; } }
        public abstract string Name { get; }
    }

}
