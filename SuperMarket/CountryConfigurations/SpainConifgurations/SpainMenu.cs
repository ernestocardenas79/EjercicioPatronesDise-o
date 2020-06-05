using InOut.v2_facade;
using SuperMarket.CountryConfigurations.MenuOptions;
using SuperMarket.MenuOptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.CountryConfigurations.SpainConifgurations
{
    internal class SpainMenu : Menu
    {
        protected override void setOptions()
        {
            menuOptions.Add(new SellOption());
            menuOptions.Add(new RevertOption());
            menuOptions.Add(new CancelOption());
            menuOptions.Add(new RepetitionOption());
        }
    }
}
