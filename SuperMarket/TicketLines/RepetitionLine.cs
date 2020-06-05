using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.TicketLines
{
    internal class RepetitionLine: TicketLine
    {
        int line;
        int times;
        internal RepetitionLine(int line, int times)
        {
            this.line = line;
            this.times = times;
        }
    }
}
