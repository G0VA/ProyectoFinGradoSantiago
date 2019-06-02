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
    public partial class DetallesPedido : Form
    {
        MostrarPedidos mos;
        PedidoDto pedidoDto;
        public DetallesPedido(MostrarPedidos mos, PedidoDto pedidoDto)
        {
            this.mos = mos;
            this.pedidoDto = pedidoDto;          
            InitializeComponent();
            iniTable("and ref_pedido = " + pedidoDto.getId());
        }

        private void iniTable(String cond)
        {
            dgvPedidos.Columns.Clear();

            Pedido p = new Pedido();
            p.getGestor().leerLineasPedidos(cond);


            DataTable tcustomers = p.getGestor().getTabla();
            dgvPedidos.Columns.Clear();

            dgvPedidos.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvPedidos.Columns.Add("CANTIDAD", "CANTIDAD");
            dgvPedidos.Columns.Add("PRECIO", "PRECIO");

            foreach (DataRow row in tcustomers.Rows)
            {
                dgvPedidos.Rows.Add(row["PRODUCTO"], row["CANTIDAD"], row["PRECIO"]);
            }
            txtId.Text = this.pedidoDto.getId();
            dgvPedidos.ClearSelection();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            mos.initTable("");
            mos.Show();
        }

        private void DetallesPedido_Shown(object sender, EventArgs e)
        {
            dgvPedidos.ClearSelection();
        }
    }
}
