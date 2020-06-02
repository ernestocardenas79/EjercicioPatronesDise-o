using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.CountryConfigurations.MenuOptions
{
    internal class SellOption : MenuOption
    {
        internal SellOption(Ticket ticket): base(ticket)
        {

        }

        protected override void execute() {
            this.ticket.sell();
        }
    }
}
