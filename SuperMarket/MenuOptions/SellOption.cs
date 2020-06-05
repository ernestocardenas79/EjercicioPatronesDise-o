using System;
using System.Collections.Generic;
using System.Text;
using InOut.v2_facade;
using SuperMarket.TicketLines;

namespace SuperMarket.CountryConfigurations.MenuOptions
{
    internal class SellOption : MenuOption
    {
        internal SellOption()
        {
            title = "Registrar venta";
        }

        public override void execute() {
            int product = io.readNumber("Codigo de Producto");
            int quantity = io.readNumber("Cantidad :");
            ticket.lines.Add(new SellLine(product, quantity));
        }
    }
}
