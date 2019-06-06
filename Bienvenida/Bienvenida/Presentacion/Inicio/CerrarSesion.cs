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
    public partial class CerrarSesion : Form
    {
        InicioApp ini;
        public CerrarSesion(InicioApp ini)
        {
            this.ini = ini;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.ini.Show();
        }
        private String encriptaPass(String pass)
        {
            string result = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(pass);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario u1 = new Usuario();

            u1.setDni(txtDni.Text);
            GestorUsuario gestor = u1.gestor();
            if (gestor.existsUser(u1.getDni()))
            {
                int count = Int16.Parse(gestor.getUnString("select count(*) from empleados where upper(DNI) = '" + u1.getDni().ToUpper() + "' and conectado = 0"));
                if (count > 0)
                {
                    MessageBox.Show("El empleado no se encuentra conectado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    u1.setContra(encriptaPass(txtPass.Text));
                    if (gestor.ValidarConx(u1) > 0)
                    {
                        MessageBox.Show("Cierre sesion correcto", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        gestor.setData("update empleados set CONECTADO = 0 where upper(DNI) = '" + u1.getDni().ToUpper() + "'");
                        ini.QuitaUser(u1);
                        this.Dispose();
                        ini.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error, contraseña incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }       
            }
            else
            {
                MessageBox.Show("Error, DNI incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
