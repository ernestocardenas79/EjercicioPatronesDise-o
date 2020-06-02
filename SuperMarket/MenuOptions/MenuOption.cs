using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.CountryConfigurations.MenuOptions
{
    internal abstract class MenuOption
    {
        protected Ticket ticket;
        internal MenuOption(Ticket ticket)
        {
            this.ticket = ticket;
        }

        protected abstract void execute();
    }
}
