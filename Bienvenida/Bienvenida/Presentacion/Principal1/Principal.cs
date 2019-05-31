using Bienvenida.Dominio;
using Bienvenida.Dominio.Gestores;
using Bienvenida.Presentacion.Pedidos;
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
            initTable("");
        }

        public void initTable(String cond)
        {
            dgvPedidos.Columns.Clear();

            Pedido p = new Pedido();
            p.getGestor().leerPedidosActivos(cond);


            DataTable tcustomers = p.getGestor().getTabla();
            dgvPedidos.Columns.Clear();

            dgvPedidos.Columns.Add("ID", "ID");
            dgvPedidos.Columns.Add("NOMBRE", "NOMBRE");
            dgvPedidos.Columns.Add("DNI", "DNI");
            dgvPedidos.Columns.Add("CLIENTE", "CLIENTE");
            dgvPedidos.Columns.Add("FORMA_PAGO", "FORMA PAGO");
            dgvPedidos.Columns.Add("TOTAL", "TOTAL");
            dgvPedidos.Columns.Add("FECHA_PEDIDO", "FECHA");
            dgvPedidos.Columns.Add("FACTURADO", "FACTURADO");

            foreach (DataRow row in tcustomers.Rows)
            {
                dgvPedidos.Rows.Add(row["ID"], row["NOMBRE"], row["DNI"], row["CLIENTE"], row["FORMA_PAGO"], row["TOTAL"], row["FECHA_PEDIDO"], row["FACTURADO"]);
            }
            this.dgvPedidos.Columns["FACTURADO"].Visible = false;

            dgvPedidos.ClearSelection();

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

        private void mostrar(object sender, EventArgs e)
        {
            dgvPedidos.ClearSelection();
        }

        private void btnNewPedido_Click(object sender, EventArgs e)
        {
            NuevoPedido nuevo = new NuevoPedido(this);
            this.Hide();
            nuevo.ShowDialog();
        }
    }
}
