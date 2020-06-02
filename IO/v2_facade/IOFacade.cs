using System;

namespace InOut.v2_facade
{
    public class IOFacade
    {
		public int readNumber(string title)
        {
			bool ok = false;
			int number=0;
			do
			{
				try
				{
					Console.Write(title);
					String input = Console.ReadLine();
					number = int.Parse(input);
					ok = true;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error de formato entero");
				}
			} while (!ok);

			return number;
		}

		public string readString(string title)
		{
			return  Console.ReadLine();
		}

		public void print(string cadena) {
			Console.WriteLine(cadena);
		}
	}
}
