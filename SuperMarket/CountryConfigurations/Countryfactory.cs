using Microsoft.Extensions.Configuration;
using SuperMarket.CountryConfigurations.SpainConifgurations;
using System;
using System.Reflection;

namespace SuperMarket.CountryConfigurations
{
    internal abstract class Countryfactory
    {
        private static Countryfactory countryFactory;

        public static Countryfactory getInstance() {
            if (countryFactory == null) {

                IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();

                var country = config["country"];

                var assembly= typeof(Countryfactory).Assembly;
                countryFactory = (Countryfactory)assembly.CreateInstance(country);
            }

            return countryFactory;
        }

        protected Countryfactory()
        {

        }

        public abstract Menu createMenu();

        public abstract Ticket createTicket();
        
    } 
}
