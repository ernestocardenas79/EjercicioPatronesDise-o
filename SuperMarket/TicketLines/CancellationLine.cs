using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.TicketLines
{
    internal class CancellationLine : TicketLine
    {
        int line;

        public CancellationLine(int line)
        {
            this.line = line;
        }
    }
}
