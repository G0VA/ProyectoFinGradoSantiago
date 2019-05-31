using Bienvenida.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenida.Presentacion.Empleados
{
    public partial class AddEmple : Form
    {
        private Emples emple;
        public AddEmple(Emples emple)
        {
            this.emple = emple;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.emple.Show();
        }

        public Boolean check()
        {
            Boolean correcto = true;

            if (String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")))
            {
                correcto = false;
            }

            if (String.IsNullOrEmpty(txtApe.Text.Replace("'", "")))
            {
                correcto = false;
            }

            if (String.IsNullOrEmpty(txtDni.Text.Replace("'", "")))
            {
                correcto = false;

            }

            if (String.IsNullOrEmpty(txtPass.Text.Replace("'", "")))
            {
                correcto = false;

            }

            if(!String.Equals(txtPass.Text.Replace("'", ""), txtPass2.Text.Replace("'", "")))
            {
                correcto = false;
                MessageBox.Show("Las contraseñas no coinciden");
            }

            return correcto;

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (check())
            {
                Usuario u = new Usuario();
                String idTexto = u.gestor().getUnString("select count(*) from empleados");
                int id = Int16.Parse(idTexto);
                id++;

                String sql = "insert into empleados (ID_EMPLE, NOMBRE, APELLIDOS, DNI, CONTRA, BORRADO, CONECTADO) VALUES (" + id + ", '" + txtNombre.Text.Replace("'", "") + "', '" + txtApe.Text.Replace("'", "") + "', '" + txtDni.Text.Replace("'", "") + "', '" + txtPass.Text.Replace("'", "") + "', 0, 0)";

                u.gestor().setData(sql);

                MessageBox.Show("Alta realizada correctamente");

                this.emple.initTable("");
            }
            else
            {
                MessageBox.Show("Error, revise los datos.");
            }
                
        }
    }
}
