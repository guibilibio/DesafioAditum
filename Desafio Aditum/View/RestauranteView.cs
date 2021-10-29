using Desafio_Aditum.Model;
using Desafio_Aditum.Util;
using System;
using System.IO;

namespace Desafio_Aditum.View
{
    class RestauranteView
    {
        public void exibir()
        {
            RestauranteModel restauranteModel = new RestauranteModel();
            
            int linha = 0;
            int aux = 0;

            DateTime horarioDesejado;

            do
            {
                Console.WriteLine("Informe o horário desejado: ");
                string horarioDesejadostr = Console.ReadLine();
                horarioDesejado = AppUtil.readDate(horarioDesejadostr);
            }while (horarioDesejado == DateTime.MinValue);

            Console.WriteLine("\n" + "Lista de restaurantes abertos neste horário: " + "\n");
            Console.WriteLine("Restaurante, " + "horário de funcionamento \n".PadLeft(15));

            // Lê dados de csv
            using (StreamReader reader = new StreamReader(@"C:\Users\gui-b\source\Repos\Desafio Aditum\Desafio Aditum\Planilha\restaurant-hours.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string restaurantes = reader.ReadLine();

                    if (linha >= 1)
                    {
                        int virgulaIndice = restaurantes.IndexOf(',');

                        if (virgulaIndice > 0)
                        {
                            string restoDepoisDaVirgula = restaurantes.Substring(virgulaIndice).Replace(",", string.Empty);
                            string[] horariofunc = restoDepoisDaVirgula.Split("-");

                            restauranteModel.horarioAbertura = Convert.ToDateTime(horariofunc[0]);
                            restauranteModel.horarioFechamento = Convert.ToDateTime(horariofunc[1]);

                            // Verificação dos restaurantes abertos, conforme o horário informado.
                            if (horarioDesejado >= restauranteModel.horarioAbertura && horarioDesejado <= restauranteModel.horarioFechamento)
                            {
                                Console.WriteLine(restaurantes);
                                aux++;
                            }
                        }
                    }
                    linha++;
                }
                // Casp não haja nenhum restaurante aberto no horário informado, apresentar aviso.
                if (aux == 0)
                    popUpAviso();
            }
            Console.WriteLine("".PadRight(50, '-'));
            Console.WriteLine("");
        }
        public void popUpAviso()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Infelizmente não a nenhum restaurante aberto no horário informado.");
        }

    }
}
