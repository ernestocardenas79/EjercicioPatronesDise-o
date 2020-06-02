using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.CountryConfigurations.SpainConifgurations
{
    internal class SpainFactory : Countryfactory
    {
        public override Menu createMenu()
        {
            return new SpainMenu();
        }

        public override Ticket createTicket()
        {
            return new SpainTicket();
        }
    }
}
