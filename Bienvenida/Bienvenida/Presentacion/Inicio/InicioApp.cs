
using Bienvenida.Dominio;
using Bienvenida.Presentacion.Empleados;
using Bienvenida.Presentacion.Inicio;
using Bienvenida.Presentacion.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenida
{
    public partial class InicioApp : Form
    {

        private List<Usuario> listaUsuarios = new List<Usuario>();
        public InicioApp()
        {
            InitializeComponent();
            this.btnCerrarSesion.Enabled = false;
            this.button1.Visible = false;
            cerrarAll();
        }

        private void cerrarAll()
        {
            Usuario u = new Usuario();
            String countText = u.gestor().getUnString("select count(*) from empleados");
            int cont = 0;
            if (!countText.Equals(""))
            {
                cont = Int16.Parse(countText);
            }
            cont++;
            int id = 1;
            while (cont > 0)
            {
                u.gestor().setData("update empleados set CONECTADO = 0 where id_emple = " + id);
                cont--;
                id++;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.listaUsuarios.Count() > 0)
            {
                if (MessageBox.Show("Empleados conectados, se cerrara la sesion de todos. ¿Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Usuario u = new Usuario();
                    int i = listaUsuarios.Count();
                    while (listaUsuarios.Count()>0)
                    {
                        u.gestor().setData("update empleados set CONECTADO = 0 where upper(DNI) = '" + listaUsuarios[0].getDni().ToUpper() + "'");
                        listaUsuarios.RemoveAt(0);
                    }
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
                
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            InicionSesion ini = new InicionSesion(this);
            this.Hide();
            ini.ShowDialog();
            if (this.listaUsuarios.Count() > 0)
            {
                Principal prin = new Principal(this.listaUsuarios, this);
                this.Hide();
                prin.Show();
                this.btnCerrarSesion.Enabled = true;
                this.button1.Visible = true;
            }else
            {
                this.btnCerrarSesion.Enabled = false;
                this.button1.Visible = false;
            }
        }
        public void añadeUser(Usuario u)
        {
            this.listaUsuarios.Add(u);
        }
        public void QuitaUser(Usuario u)
        {
            for(int i = 0; i < listaUsuarios.Count(); i++)
            {
                if (listaUsuarios[i].getDni().Equals(u.getDni()))
                {
                    listaUsuarios.RemoveAt(i);
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion ini = new CerrarSesion(this);
            this.Hide();
            ini.ShowDialog();
            if (this.listaUsuarios.Count() > 0)
            {
                Principal prin = new Principal(this.listaUsuarios, this);
                this.Hide();
                prin.Show();
                this.button1.Visible = true;
                this.button1.Visible = true;
            }else
            {
                this.btnCerrarSesion.Enabled = false;
                this.button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal prin = new Principal(this.listaUsuarios,this);
            this.Hide();
            prin.Show();
        }

        private void refrescar(object sender, EventArgs e)
        {
           
            if (this.listaUsuarios.Count() > 0)
            {
                
            }
        }

        private void btnEmple_Click(object sender, EventArgs e)
        {
            string passAdmin = Microsoft.VisualBasic.Interaction.InputBox("Introducir contraseña Admin");

            if (passAdmin.Equals("SYS"))
            {
                Emples emples = new Emples(this);
                this.Hide();
                emples.ShowDialog();
            }else
            {
                MessageBox.Show("Error, Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
