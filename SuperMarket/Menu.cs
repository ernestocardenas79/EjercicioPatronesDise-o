using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket
{
    internal abstract class Menu
    {
        Ticket ticket;

        public void execute(Ticket ticket) {
            this.ticket = ticket;
        }
    }
}
