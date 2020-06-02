using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.CountryConfigurations
{
    internal abstract class Menu
    {
        Ticket ticket;

        public void execute(Ticket ticket) {
            this.ticket = ticket;
        }
    }
}
