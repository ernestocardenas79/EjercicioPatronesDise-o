using System;
using System.Collections.Generic;
using System.Text;
using InOut.v1_bad;
using SuperMarket.TicketLines;

namespace SuperMarket.CountryConfigurations.MenuOptions
{
    internal class CancelOption: MenuOption
    {
        internal CancelOption()
        {
            title = "Cancelar Liena";
        }

        public override void execute()
        {
            var line = io.readNumber("Especificar la linea a cancelar: ");
            this.ticket.lines.Add(new CancellationLine(line));
        }
    }
}
