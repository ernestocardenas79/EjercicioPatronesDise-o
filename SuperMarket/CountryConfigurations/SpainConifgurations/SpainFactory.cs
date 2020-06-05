using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.CountryConfigurations.SpainConifgurations
{
    internal class SpainFactory : Countryfactory
    {
        internal SpainFactory()
        {
            this.menu = new SpainMenu();
        }

        public override Ticket ticketBuilder()
        {
            return new SpainTicket();
        }
    }
}
