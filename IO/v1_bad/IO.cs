using System;
using System.IO;

namespace InOut.v1_bad
{
    public class IO
    {
		public void exec()
		{
			int code = 0;
			bool ok = false;
			do
			{
				try
				{
					Console.Write("Introduzca el código: ");
					String input =  Console.ReadLine();
					code = int.Parse(input);
					ok = true;
				}
				catch (IOException ex)
				{
					Console.WriteLine("Error de formato entero");
				}
			} while (!ok);

			int amount = 0;
			ok = false;
			do
			{
				try
				{
					Console.Write("Introduzca la cantidad: ");
					String input = Console.ReadLine();
					amount = int.Parse(input);
					ok = true;
				}
				catch (IOException ex)
				{
					Console.WriteLine("Error de formato entero");
				}
			} while (!ok);

			Console.WriteLine("Código: " + code);
			Console.WriteLine("Cantidad: " + amount);
		}
	}
}
