using Bienvenida.Dominio;
using Bienvenida.Dominio.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenida.Presentacion.Inicio
{
    public partial class InicionSesion : Form
    {
        InicioApp ini;
        public InicionSesion(InicioApp ini)
        {
            this.ini = ini;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.ini.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario u1 = new Usuario();
            
            u1.setDni(txtDni.Text);
            GestorUsuario gestor = u1.gestor();
            if (gestor.existsUser(u1.getDni()))
            {
                u1.setContra(txtPass.Text);
                if (gestor.ValidarConx(u1)>0)
                {
                    MessageBox.Show("Inicio sesion correcto");
                }
                else
                {
                    MessageBox.Show("Error, contraseña incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Error, DNI incorrecto");
            }

        }
    }
}
