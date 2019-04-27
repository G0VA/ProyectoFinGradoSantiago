
using Bienvenida.Presentacion.Inicio;
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
        public InicioApp()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            InicionSesion ini = new InicionSesion(this);
            this.Hide();
            ini.ShowDialog();
        }
    }
}
