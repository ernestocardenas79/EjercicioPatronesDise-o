using System;
using System.Collections.Generic;
using System.Text;
using SuperMarket.CountryConfigurations.MenuOptions;

namespace SuperMarket.MenuOptions
{
    internal class ExitOption : MenuOption
    {
        internal bool isClosed { get; private set; }

        public ExitOption()
        {
            title = "Salir";
        }

        public override void execute()
        {
            ticket.close();
            isClosed = true;
        }

        internal void reset() {
            isClosed = false;
        }
    }
}
