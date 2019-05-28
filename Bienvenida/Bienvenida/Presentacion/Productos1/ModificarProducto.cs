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

namespace Bienvenida.Presentacion.Productos
{
    public partial class ModificarProducto : Form
    {
        Productos pro;
        public ModificarProducto(Productos pro)
        {
            this.pro = pro;
            InitializeComponent();
        }

        public void initTipo1(String cond)
        {
            Producto p = new Producto();
            p.getGestor().readInDB("TIPO", "PRODUCTOS_TIPO1", cond);
            DataTable tipo1 = p.getGestor().getTabla();
            cbTipo2.Items.Clear();
            foreach (DataRow row in tipo1.Rows)
            {
                cbTipo1.Items.Add(row["TIPO"]);
            }
        }

        public void initTipo2(String cond)
        {
            Producto p = new Producto();
            p.getGestor().readInDB("TIPO", "PRODUCTOS_TIPO2", cond);
            DataTable tipo1 = p.getGestor().getTabla();
            foreach (DataRow row in tipo1.Rows)
            {
                cbTipo2.Items.Add(row["TIPO"]);
            }
        }

        private void cambioValor(object sender, EventArgs e)
        {
            cbTipo2.Items.Clear();
            String cond = " Where t1 = (Select id from PRODUCTOS_TIPO1 where TIPO = '" + cbTipo1.SelectedItem.ToString() + "')";
            initTipo2(cond);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.pro.Show();
        }
    }
}
