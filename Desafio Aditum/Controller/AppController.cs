using Desafio_Aditum.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aditum.Controller
{
    class AppController
    {
        private AppView appView;
		private RestauranteView restauranteView;

		public AppController()
		{
			this.appView = new AppView();
			this.restauranteView = new RestauranteView();
		}
		public void executar()
        {
			int op = appView.Menu();

			while (op != 0)
			{
				switch (op)
				{
					case 1:
						restauranteView.exibir();
						break;
					default:
						appView.popUpErro();
						break;
				}

				op = appView.Menu();
			}
		}
        
    }
}
