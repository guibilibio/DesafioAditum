using Desafio_Aditum.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Aditum.Controller
{

    class RestauranteController
    {
        private RestauranteView restauranteView = new RestauranteView();

        public RestauranteController()
        {
            this.restauranteView = new RestauranteView();
        }
        public void init()
        {
            restauranteView.exibir();
        }
    }
}
