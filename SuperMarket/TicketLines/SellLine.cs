
namespace SuperMarket.TicketLines
{
    internal class SellLine: TicketLine
    {
        internal SellLine()
        {
            int product = io.readNumber("Codigo de Producto");
            int quantity = io.readNumber("Cantidad :");
        }
    }
}
