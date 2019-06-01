using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio
{
    public class PedidoDto
    {
        private String id;
        private String nombre;
        private String dni;
        private String cliente;
        private String pago;
        private String total;
        private String fecha;

        public PedidoDto()
        {

        }

        public PedidoDto(String id, String nombre, String dni, String cliente, String pago, String total, String fecha)
        {
            this.id = id;
            this.nombre = nombre;
            this.dni = dni;
            this.cliente = cliente;
            this.pago = pago;
            this.total = total;
            this.fecha = fecha;
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

        public void setDni(String dni)
        {
            this.dni = dni;
        }
        public String getDni()
        {
            return this.dni;
        }

        public void setCliente(String cliente)
        {
            this.cliente = cliente;
        }
        public String getCliente()
        {
            return this.cliente;
        }

        public void setPago(String pago)
        {
            this.pago = pago;
        }
        public String getPago()
        {
            return this.pago;
        }

        public void setTotal(String total)
        {
            this.total = total;
        }
        public String getTotal()
        {
            return this.total;
        }

        public void setFecha(String fecha)
        {
            this.fecha = fecha;
        }
        public String getFecha()
        {
            return this.fecha;
        }
    }
}
