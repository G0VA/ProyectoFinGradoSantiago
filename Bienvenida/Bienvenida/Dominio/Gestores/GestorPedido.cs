using Bienvenida.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio.Gestores
{
    
    class GestorPedido
    {
        private DataTable tabla;
        public GestorPedido()
        {
            tabla = new DataTable();
        }

        public DataTable getTabla()
        {
            return this.tabla;
        }

        public void leerPedidosActivos(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("select o.id_pedido id, e.nombre, e.dni, o.ref_cliente cliente, f.forma_pago, o.total, o.fecha_pedido, o.facturado from pedidos o inner join empleados e on e.id_emple = o.REF_EMPLE inner join FORMAS_PAGO f on f.ID_FPAGO = o.REF_PAGO where o.pagado = 0 " + cond + " order by id_pedido", "exam");
            tabla = data.Tables["exam"];
        }

        public void leerTodosPedidos(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("select o.id_pedido id, e.nombre, e.dni, o.ref_cliente cliente, f.forma_pago, o.total, o.fecha_pedido, o.facturado, o.pagado from pedidos o inner join empleados e on e.id_emple = o.REF_EMPLE inner join FORMAS_PAGO f on f.ID_FPAGO = o.REF_PAGO where 1 = 1 " + cond + " order by id_pedido", "exam");
            tabla = data.Tables["exam"];
        }

        public void leerLineasPedidos(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("select p.nombre_producto PRODUCTO, o.cantidad, p.precio from PEDIDOS_PRODUCTOS o inner join productos p on p.ID_PRODUCTO = o.REF_PRODUCTO where 1 = 1 " + cond + " order by id_pedido_produc", "exam");
            tabla = data.Tables["exam"];
        }

        public void readInDB(String column, String table, String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + column + " from " + table + " " + cond, "exam");
            tabla = data.Tables["exam"];
        }

        public String getUnString(String sql)
        {
            ConnectOracle select = new ConnectOracle();
            return select.getData(sql);
        }

        public void setData(String sentencia)
        {
            ConnectOracle update = new ConnectOracle();
            update.setData(sentencia);
        }
    }
}
