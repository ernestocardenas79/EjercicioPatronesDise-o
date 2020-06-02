using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.CountryConfigurations.MenuOptions
{
    internal class CancelOption: MenuOption
    {
        internal CancelOption(Ticket ticket):base(ticket)
        {

        }

        protected override void execute()
        {
            this.ticket.cancel();
        }
    }
}
