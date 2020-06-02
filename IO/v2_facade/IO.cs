using System;
using System.IO;

namespace InOut.v2_facade
{
    public class IO
    {
		public void exec()
		{

			IOFacade io = new IOFacade();
			int code = 0;
			int amount = 0;

			code = io.readNumber("Introduzca el código: ");
			amount = io.readNumber("Introduzca la cantidad: ");

			io.print("Código: " + code);
			io.print("Cantidad: " + amount);
		}
	}
}
