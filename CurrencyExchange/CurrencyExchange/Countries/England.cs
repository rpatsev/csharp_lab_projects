
namespace CurrencyExchange.Countries
{
    class England : Country
    {
        public override string Name
        {
            get
            {
                return "England";
            }
        }

        public override Currency Currency
        {
            get
            {
                return Currency.GBP; 
            }
        }
    }
}
