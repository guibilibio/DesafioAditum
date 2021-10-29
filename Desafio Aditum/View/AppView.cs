using Desafio_Aditum.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aditum.View
{
    class AppView
    {
        public int Menu()
        {
            //int op = -1;

            Console.WriteLine("------------------------------");
            Console.WriteLine("------  Desafio Aditum  ------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("--                          --");
            Console.WriteLine("--   1 - Informar horário   --");
            Console.WriteLine("--   0 - Sair               --");
            Console.WriteLine("--                          --");
            Console.WriteLine("Opção desejada: ");
            var op = Console.ReadLine();
            int opInt = AppUtil.readint(op);

            return opInt;
        }

        public void popUpErro()
        {
            Console.WriteLine("Opção inválida!");
        }
        public void mensagemSaida()
        {
            Console.WriteLine("Obrigado. Até Logo!");
        }
    }
}
