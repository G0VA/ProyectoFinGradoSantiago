using Bienvenida.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio.Gestores
{
    public class GestorUsuario
    {
        private DataTable tabla;
        public GestorUsuario()
        {
            tabla = new DataTable();
        }

        public DataTable getTabla()
        {
            return this.tabla;
        }

        public void leerUsers(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("select dni, nombre from empleados where borrado = 0 " + cond + " order by id_emple", "exam");
            tabla = data.Tables["exam"];
        }

        public bool existsUser(String dni)
        {
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "empleados", "UPPER(dni)= '" + dni.ToUpper() + "' AND borrado=0"));
            if (resp > 0)
            {
                return true;
            }
            return false;
        }

        //public bool ValidarConx(String contra)
        //{
        //    ConnectOracle search = new ConnectOracle();
        //    int resp = Convert.ToInt16(search.DLookUp("count(*)", "empleados", "UPPER(contra)= '" + contra.ToUpper() + "' AND borrado=0"));
        //    if (resp > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public int ValidarConx(Usuario u1)
        {
            ConnectOracle Search = new ConnectOracle();
            String cond = "UPPER(dni) ='" + u1.getDni().ToUpper() + "' AND CONTRA ='" + u1.getContra() + "'";

            Object resul = Search.DLookUp("count(*)", "empleados", cond);
            return Int32.Parse(resul.ToString());
        }
        public void setData(String sentencia)
        {
            ConnectOracle update = new ConnectOracle();
            update.setData(sentencia);
        }

        public String getUnString(String sql)
        {
            ConnectOracle select = new ConnectOracle();
            return select.getData(sql);
        }

        public static bool existEmpleConect(String id)
        {
            bool exist = false;
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "orders", "IDORDER= '" + id + "' AND DELETED=0"));
            if (resp > 0)
            {
                exist = true;
            }
            return exist;
        }
    }
}
