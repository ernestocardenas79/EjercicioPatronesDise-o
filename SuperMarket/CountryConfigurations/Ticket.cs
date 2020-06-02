using System.Collections.Generic;

namespace SuperMarket.CountryConfigurations
{
    internal abstract class Ticket
    {
        protected abstract void header();
        protected abstract void footer();

        //protected List<Line> lineas;

        //internal void addLine(LineOperation line ) {
        //    lineas.Add(line);
        //}
    }
}
