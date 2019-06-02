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

namespace Bienvenida.Presentacion.Pedidos
{
    public partial class MostrarPedidos : Form
    {
        private Principal.Principal prin;
        public MostrarPedidos(Principal.Principal prin)
        {
            this.prin = prin;
            InitializeComponent();
            initTable("");
            iniCombox();
            date.Enabled = false;
        }

        private void MostrarPedidos_Shown(object sender, EventArgs e)
        {
            dgvPedidos.ClearSelection();
        }

        public void initTable(String cond)
        {
            dgvPedidos.Columns.Clear();

            Pedido p = new Pedido();
            p.getGestor().leerTodosPedidos(cond);


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
            dgvPedidos.Columns.Add("PAGADO", "PAGADO");

            foreach (DataRow row in tcustomers.Rows)
            {
                dgvPedidos.Rows.Add(row["ID"], row["NOMBRE"], row["DNI"], row["CLIENTE"], row["FORMA_PAGO"], row["TOTAL"], row["FECHA_PEDIDO"], row["FACTURADO"], row["PAGADO"]);
            }
            this.dgvPedidos.Columns["FACTURADO"].Visible = false;
            this.dgvPedidos.Columns["PAGADO"].Visible = false;

            dgvPedidos.ClearSelection();
            dgvPedidosColor();

        }

        private void dgvPedidosColor()
        {
            foreach (DataGridViewRow rowp in dgvPedidos.Rows)
            {   
                if (Convert.ToInt32(rowp.Cells[7].Value) == 0)
                {
                    rowp.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    rowp.DefaultCellStyle.BackColor = Color.Orange;
                }

                if (Convert.ToInt32(rowp.Cells[8].Value) == 1)
                {
                    rowp.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void iniCombox()
        {
            Usuario user = new Usuario();
            user.gestor().readInDB("DNI", "empleados", "where borrado = 0");
            DataTable tipo1 = user.gestor().getTabla();
            cbEmple.Items.Clear();
            foreach (DataRow row in tipo1.Rows)
            {
                cbEmple.Items.Add(row["DNI"]);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            prin.initTable("");
            prin.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String sql = "";

            if (!String.IsNullOrEmpty(txtCliente.Text.Replace("'", "")))
            {
                sql += " And upper(o.ref_cliente) like '%" + txtCliente.Text.ToUpper().Replace("'", "") + "%' ";
            }

            if (date.Enabled)
            {
                sql += " And trunc(o.fecha_pedido) = to_date('" + date.Text.Replace("'", "") + "','dd/MM/yyyy')";
            }

            if (ckFacturado.Checked)
            {
                sql += " And o.facturado = 1";
            }

            if (ckPagado.Checked)
            {
                sql += " And o.pagado = 1";
            }

            if (!String.IsNullOrEmpty(txtId.Text.Replace("'", "")))
            {
                sql += " And upper(o.id_pedido) like '%" + txtId.Text.ToUpper().Replace("'", "") + "%' ";
            }

            if (cbEmple.SelectedIndex != -1)
            {
                sql += " And e.dni like '%" + cbEmple.SelectedItem.ToString().Replace("'", "") + "%' ";
            }

            initTable(sql);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            date.Value = DateTime.Today;
            ckDate.Checked = false;
            ckFacturado.Checked = false;
            ckPagado.Checked = false;
            txtCliente.Text = "";
            cbEmple.SelectedIndex = -1;
            txtId.Text = "";
            initTable("");
        }

        private void ckDateCambio(object sender, EventArgs e)
        {
            if (ckDate.Checked)
                date.Enabled = true;
            else
                date.Enabled = false;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            bool n = dgvPedidos.CurrentRow.Selected;
            if (n)
            {
                int id = int.Parse(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value.ToString());
                PedidoDto pedidoDto = new PedidoDto(
                    dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value.ToString(),
                    dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[1].Value.ToString(),
                    dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[2].Value.ToString(),
                    dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[3].Value.ToString(),
                    dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[4].Value.ToString(),
                    dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[5].Value.ToString(),
                    dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[6].Value.ToString()
                    );
                DetallesPedido mod = new DetallesPedido(this, pedidoDto);
                this.Hide();
                mod.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error, Selecciona el pedido a mostrar");
            }
        }
    }
}
