using CurrencyExchange.Countries;
using System;

namespace CurrencyExchange
{
    public static class Portal_
    {
        private const int CountriesCount = 5;
        private static readonly Country[] _countries = new Country[CountriesCount];

        static Portal_()
        {
            _countries[0] = new England();
            _countries[1] = new France();
            _countries[2] = new Germany();
            _countries[3] = new Spain();
            _countries[4] = new Ukraine();
        }

        public static ICountry Work()
        {
            var random = new Random();
            return _countries[random.Next(CountriesCount)];
        }
    }
}
