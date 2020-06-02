using System;
using System.Collections.Generic;
using InOut.v2_facade;

namespace SuperMarket
{
    internal class Ticket
    {
        private IOFacade io;

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

        public void sell() {
            int product = io.readNumber("Codigo de Producto");
            int quantity = io.readNumber("Cantidad :");
        }

        public void repeat()
        {
            int line = io.readNumber("Linea a repetir");
            int times = io.readNumber("Cantidad");

        }

        public void cancel()
        {
            int line = io.readNumber("Linea a cancelar");
        }

        //protected List<Line> lineas;

        //internal void addLine(LineOperation line ) {
        //    lineas.Add(line);
        //}

        protected void close() {
            this.footer();
        }
    }
}
