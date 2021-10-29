using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aditum.Util
{
    public class AppUtil
    {
		public static int readint(string opc)
		{
			int op;

			try
			{
				op = int.Parse(opc);
				return op;
			}
			catch (Exception e) // Caso seja informado um formato diferente do aceito, apresentado mensagem.
			{
				Console.WriteLine("------------------------------------");
				Console.WriteLine("Escolha uma opção novamente!");
				return -1;
			}
		}
		public static DateTime readDate(String daateStr)
        {
			DateTime dt = new DateTime();

            try
            {
                if (daateStr.Equals(""))
                {
					return new DateTime();
                }

				dt = Convert.ToDateTime(daateStr);

            }catch(Exception e)
            {
				Console.WriteLine("Horário Invalido!");
				Console.WriteLine();
				return dt;
            }
			return dt;
        }
	}
}
