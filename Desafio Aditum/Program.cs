using System;
using Desafio_Aditum.Controller;

namespace Desafio_Aditum
{
    class Program
    {
        static void Main(string[] args)
        {
            AppController appController = new AppController();
            appController.executar();
        }
    }
}
