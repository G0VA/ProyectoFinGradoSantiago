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

namespace Bienvenida.Presentacion.Principal
{
    public partial class Principal : Form
    {
        List<Usuario> users = new List<Usuario>();
        InicioApp ini;
        DateTime hoy;
        public Principal(List<Usuario> users, InicioApp ini)
        {
            InitializeComponent();
            this.users = users;
            this.ini = ini;
            this.hoy = DateTime.Today;
            lblFecha.Text = hoy.ToString("d");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ini.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos.Productos pro = new Productos.Productos(this);
            this.Hide();
            pro.ShowDialog();
        }
    }
}
