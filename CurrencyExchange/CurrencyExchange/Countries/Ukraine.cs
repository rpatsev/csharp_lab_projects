using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange.Countries
{
    public class Ukraine : Country
    {
        public override string Name
        {
            get
            {
                return "Ukraine";
            }
        }

        public override Currency Currency
        {
            get
            {
                return Currency.UAH; 
            }
        }
    }
}
