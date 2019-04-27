using Bienvenida.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio.Gestores
{
    class GestorUsuario
    {
        public GestorUsuario()
        {

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

    }
}
