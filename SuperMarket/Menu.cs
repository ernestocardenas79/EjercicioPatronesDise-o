using System;
using System.Collections.Generic;
using System.Text;
using InOut.v2_facade;
using SuperMarket.CountryConfigurations.MenuOptions;
using SuperMarket.MenuOptions;

namespace SuperMarket
{
    internal abstract class Menu
    {
        IOFacade io;
        protected List<MenuOption> menuOptions;
        protected Array menuOptionList;
        ExitOption exitOption;

        internal Menu()
        {
            io = new IOFacade();
            menuOptions = new List<MenuOption>();
            setOptions();
            exitOption = new ExitOption();
            menuOptions.Add(exitOption);
            menuOptionList = menuOptions.ToArray();
        }

        private void setTicket(Ticket ticket) {
            menuOptions.ForEach(mo=> mo.set(ticket));
        }

        public void execute(Ticket ticket) {
            setTicket(ticket);
            exitOption.reset();
            do
            {
                write();
                int option = io.readNumber("elije una opción: ");
                var menuOption= (MenuOption)menuOptionList.GetValue(option);
                menuOption.execute();
            } while (!exitOption.isClosed);
        }

        protected abstract void setOptions();

        void write()
        {

        }

    }
}
