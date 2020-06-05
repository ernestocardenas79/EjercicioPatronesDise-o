using System;
using System.Collections.Generic;
using System.Text;
using InOut.v2_facade;

namespace SuperMarket.CountryConfigurations.MenuOptions
{
    internal abstract class MenuOption
    {
        protected Ticket ticket;
        protected IOFacade io;

        public MenuOption()
        {
            io = new IOFacade();
        }

        public string title { get; protected set; }

        internal void set(Ticket ticket)
        {
            this.ticket = ticket;
        }

        public abstract void execute();
    }
}
