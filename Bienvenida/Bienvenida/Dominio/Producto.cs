using Bienvenida.Dominio.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio
{
    class Producto
    {

        private GestorProducto gestor;

        public Producto()
        {
            gestor = new GestorProducto();
        }

        public GestorProducto getGestor()
        {
            return this.gestor;
        }
    }
}
