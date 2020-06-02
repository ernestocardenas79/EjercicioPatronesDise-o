using SuperMarket.CountryConfigurations;

namespace SuperMarketConsole
{
    public class SuperMarket
    {
        public static void Main(string[] args)
        {
            new SuperMarket().open();
        }

        bool exit = true;

        internal void open() {
            var countryFactory = Countryfactory.getInstance();
            var menu = countryFactory.createMenu();

            do
            {
                var ticket = countryFactory.createTicket();
                menu.execute(ticket);

            } while (!exit);
        }
    }
}
