using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio
{
    public class ProductoDto
    {
        private String id;
        private String nombre;
        private String t1;
        private String t2;
        private String stock;
        private String precio;

        public ProductoDto ()
        {

        }

        public ProductoDto(String id, String nombre, String t1, String t2, String stock, String precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.t1 = t1;
            this.t2 = t2;
            this.stock = stock;
            this.precio = precio;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public String getId()
        {
            return this.id;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setT1(String t1)
        {
            this.t1 = t1;
        }

        public String getT1()
        {
            return this.t1;
        }
        public void setT2(String t2)
        {
            this.t2 = t2;
        }

        public String getT2()
        {
            return this.t2;
        }
        public void setStock(String stock)
        {
            this.stock = stock;
        }

        public String getStock()
        {
            return this.stock;
        }
        public void setPrecio(String precio)
        {
            this.precio = precio;
        }

        public String getPrecio()
        {
            return this.precio;
        }

    }
}
