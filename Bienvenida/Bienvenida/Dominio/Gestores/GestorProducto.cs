using Bienvenida.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio.Gestores
{
    class GestorProducto
    {

        private DataTable tabla;

        public GestorProducto()
        {
            tabla = new DataTable();
        }

        public DataTable getTabla()
        {
            return this.tabla;
        }

        public void leerProductos()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from productos order by id_producto", "exam");
            tabla = data.Tables["exam"];
        }

        public void leerProductos(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("select p.id_producto, p.nombre_producto, t1.tipo TIPO1, t2.tipo TIPO2, p.stock, p.precio from productos p inner join productos_tipo1 t1 on p.tipo1 = t1.id inner join productos_tipo2 t2 on p.tipo2 = t2.id where borrado = 0 " + cond + " order by id_producto", "exam");
            tabla = data.Tables["exam"];
        }

        public void leerTipo1()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from productos_tipo1 order by id", "exam");
            tabla = data.Tables["exam"];
        }

        public void leerTipo2(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from productos_tipo2 " + cond + " order by id", "exam");
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
