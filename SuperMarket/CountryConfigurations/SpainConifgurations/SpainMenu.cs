using InOut.v2_facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.CountryConfigurations.SpainConifgurations
{
    internal class SpainMenu : Menu
    {
        public SpainMenu()
        {
            var exit = true;
            var io = new IOFacade();
            do
            {
                io.print("1. Añadir linea de venta");
                io.print("2. Añadir lista de anulación");
                int option = io.readNumber("opción?");

                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            } while (!exit);
        }
    }
}
