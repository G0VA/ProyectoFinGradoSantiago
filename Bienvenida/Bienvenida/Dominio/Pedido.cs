using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio.Gestores
{
    class Pedido
    {
        private GestorPedido gestor;

        public Pedido()
        {
            gestor = new GestorPedido();
        }

        public GestorPedido getGestor()
        {
            return this.gestor;
        }
    }
}
