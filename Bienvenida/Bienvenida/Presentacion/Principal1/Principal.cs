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
            iniCombox();
            mideStock();
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
            }
        }

        private void iniCombox()
        {
            Usuario user = new Usuario();
            user.gestor().readInDB("NOMBRE", "empleados", "where borrado = 0 and conectado = 1");
            DataTable tipo1 = user.gestor().getTabla();
            cbEmple.Items.Clear();
            foreach (DataRow row in tipo1.Rows)
            {
                cbEmple.Items.Add(row["NOMBRE"]);
            }
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
            iniCombox();
            mideStock();
        }

        public void mideStock()
        {
            Producto p = new Producto();
            p.getGestor().leerProductosAvisar();
            DataTable tProducts = p.getGestor().getTabla();

            foreach (DataRow row in tProducts.Rows)
            {
                MessageBox.Show("///ALERTA/// el producto "+ row["NOMBRE"].ToString()+" tiene el stock inferior a 10.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                p.getGestor().setData("update productos set avisado = 1 where id_producto = "+ row["ID"].ToString());
            }
        }

        private void btnNewPedido_Click(object sender, EventArgs e)
        {
            NuevoPedido nuevo = new NuevoPedido(this);
            this.Hide();
            nuevo.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            cbEmple.SelectedIndex = -1;
            initTable("");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String sql = "";

            if (!String.IsNullOrEmpty(txtCliente.Text.Replace("'", "")))
            {
                sql += " And upper(ref_cliente) like '%" + txtCliente.Text.ToUpper().Replace("'", "") + "%' ";
            }

            if (cbEmple.SelectedIndex != -1)
            {
                sql += " And nombre like '%" + cbEmple.SelectedItem.ToString().Replace("'", "") + "%' ";
            }

            initTable(sql);
        }

        private void btnModPedido_Click(object sender, EventArgs e)
        {
            bool n = dgvPedidos.CurrentRow.Selected;
            if (n)
            {
                Pedido p = new Pedido();              
                int id = int.Parse(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value.ToString());
                int facturado = int.Parse(p.getGestor().getUnString("select facturado from pedidos where id_pedido = " + id));
                if (facturado==0)
                {
                    PedidoDto pedidoDto = new PedidoDto(
                        dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value.ToString(),
                        dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[1].Value.ToString(),
                        dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[2].Value.ToString(),
                        dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[3].Value.ToString(),
                        dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[4].Value.ToString(),
                        dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[5].Value.ToString(),
                        dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[6].Value.ToString()
                        );
                    ModificaPedido mod = new ModificaPedido(this, pedidoDto);
                    this.Hide();
                    mod.ShowDialog();
                }else
                {
                    MessageBox.Show("Un pedido que ya se ha dado la cuenta no se puede modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
                MessageBox.Show("Error, Selecciona el pedido a modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            bool n = dgvPedidos.CurrentRow.Selected;
            if (n)
            {
                int idPedido = int.Parse(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value.ToString());
                Pedido p = new Pedido();
                int idEmple = int.Parse(p.getGestor().getUnString("select ref_emple from pedidos where id_pedido = "+idPedido));

                Pedidos.Ticket.PintaRecibo pinta = new Pedidos.Ticket.PintaRecibo(idEmple,idPedido);
                pinta.Show();
                p.getGestor().setData("update pedidos set facturado = 1 where id_pedido = "+idPedido);
                initTable("");
            }
            else
            {
                MessageBox.Show("Error, Selecciona el pedido a sacar Ticket", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            bool n = dgvPedidos.CurrentRow.Selected;
            if (n)
            {
                int idfacturado = int.Parse(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[7].Value.ToString());
                if(idfacturado == 1)
                {
                    int idPedido = int.Parse(dgvPedidos.Rows[dgvPedidos.CurrentRow.Index].Cells[0].Value.ToString());
                    Pedido p = new Pedido();
                    p.getGestor().setData("update pedidos set pagado = 1 where id_pedido = " + idPedido);
                    MessageBox.Show("Pedido pagado", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    initTable("");
                }
                else
                {
                    MessageBox.Show("Error, el pedido debe estar facturado antes de pagar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, Selecciona el pedido a pagar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogPedidos_Click(object sender, EventArgs e)
        {
            MostrarPedidos ped = new MostrarPedidos(this);
            this.Hide();
            ped.ShowDialog();
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            Principal1.Contabilidad conta = new Principal1.Contabilidad(this);
            this.Hide();
            conta.ShowDialog();
        }

        private void cbEmple_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
