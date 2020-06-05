using System;
using System.Collections.Generic;
using System.Text;
using SuperMarket.CountryConfigurations.MenuOptions;
using SuperMarket.TicketLines;

namespace SuperMarket.MenuOptions
{
    internal class RepetitionOption : MenuOption
    {
        public override void execute()
        {
            var line = io.readNumber("linea a repetir?: ");
            var times = io.readNumber("¿Cuantas veces?: ");
            this.ticket.lines.Add(new RepetitionLine(line, times));
        }
    }
}
