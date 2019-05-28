using Bienvenida.Dominio.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienvenida.Dominio
{
    public class Usuario
    {
        private String dni;
        private String contra;
        private GestorUsuario g;

        public Usuario()
        {
            g = new GestorUsuario();
        }


        public GestorUsuario gestor()
        {
            return g;
        }
        public String getDni()
        {
            return this.dni;
        }

        public String getContra()
        {
            return this.contra;
        }


        public void setDni(String dni)
        {
            this.dni = dni;
        }

        public void setContra(String contra)
        {
            this.contra = contra;
        }
    }
}
