using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    public static class Me
    {
        private const int CurrencyCount = 2;
        private static readonly Currency[] _availableCurrency = new Currency[CurrencyCount];

        static Me()
        {
            _availableCurrency[0] = Currency.UAH;
            _availableCurrency[1] = Currency.EUR;
        }

        public static bool HasCurrency(Currency currency)
        {
            for (int i = 0; i < CurrencyCount; i++)
            {
                if(_availableCurrency[i] == currency)
                {
                    return true;
                }
            }
            return false;
        } 
    }
}
