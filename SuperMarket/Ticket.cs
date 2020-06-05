using System;
using System.Collections.Generic;
using InOut.v2_facade;
using SuperMarket.TicketLines;

namespace SuperMarket
{
    internal class Ticket
    {
        private IOFacade io;
        internal List<TicketLine> lines;

        public Ticket()
        {
            io = new IOFacade();
        }

        private void header() {
            Console.WriteLine("Ticket Header");
        }

        private void footer() { 
            Console.WriteLine("Ticket Footer");
        }

        internal void close() {
            this.footer();
        }

        internal void print() { 
        
        }
    }
}
