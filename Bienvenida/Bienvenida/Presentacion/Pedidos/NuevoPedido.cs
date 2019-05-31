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
    public partial class NuevoPedido : Form
    {
        private Principal.Principal prin;
        ProductoDto prod;
        private float t;
        public NuevoPedido(Principal.Principal prin)
        {
            this.prin = prin;
            InitializeComponent();
            iniCombox();
            iniTable();
            txtTotal.Enabled = false;
        }

        private void btnCreaPedido_Click(object sender, EventArgs e)
        {
            
        }

        private void iniCombox()
        {
            Usuario user = new Usuario();
            user.gestor().readInDB("DNI","empleados","where borrado = 0 and conectado = 1");
            DataTable tipo1 = user.gestor().getTabla();
            cbEmples.Items.Clear();
            foreach (DataRow row in tipo1.Rows)
            {
                cbEmples.Items.Add(row["DNI"]);
            }

            Pedido p = new Pedido();
            p.getGestor().readInDB("FORMA_PAGO", "FORMAS_PAGO", "");
            DataTable tipo2 = p.getGestor().getTabla();
            cbFPago.Items.Clear();
            foreach (DataRow row in tipo2.Rows)
            {
                cbFPago.Items.Add(row["FORMA_PAGO"]);
            }
        }

        public void iniTable()
        {
            dgvNuevoPedido.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvNuevoPedido.Columns.Add("CANTIDAD", "CANTIDAD");
            dgvNuevoPedido.Columns.Add("PRECIO", "PRECIO");
        }

        public void updateProducto(ProductoDto producto)
        {
            this.prod = producto;
            txtProduct.Text = producto.getNombre();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            prin.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Productos.Productos productos = new Productos.Productos(this);
            this.Hide();
            productos.ShowDialog();
            this.nudAmount.Value = 1;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            this.t = 0;          
            Pedido o = new Pedido();
            int stock = (prod != null) ? Int32.Parse(o.getGestor().getUnString("Select stock from productos where id_producto=" + prod.getId())) : -1;
            if (nudAmount.Value <= stock && stock != -1)
            {
                if (!String.IsNullOrEmpty(txtProduct.Text.Replace("'", "")))
                {
                    dgvNuevoPedido.Rows.Add(txtProduct.Text.Replace("'", ""), nudAmount.Value.ToString().Replace("'", ""), prod.getPrecio().Replace("'", ""));

                    for (int i = 0; i < dgvNuevoPedido.RowCount; i++)
                    {
                        this.t = this.t + (float.Parse(dgvNuevoPedido.Rows[i].Cells[1].Value.ToString()) * float.Parse(dgvNuevoPedido.Rows[i].Cells[2].Value.ToString()));
                    }
                    txtTotal.Text = Convert.ToString(t);
                    dgvNuevoPedido.ClearSelection();

                }
                else
                {
                    MessageBox.Show("Debes seleccionar un producto");
                }
            }
            else
            {
                if (stock != -1)
                {
                    MessageBox.Show("No queda stock suficiente de este producto");
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un producto");
                }
                    
            }
        }

        private void NuevoPedido_Shown(object sender, EventArgs e)
        {
            dgvNuevoPedido.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNuevoPedido.RowCount > 0)
            {
                bool n = dgvNuevoPedido.CurrentRow.Selected;
                if (n)
                {
                    this.t = 0;
                   // if (dgvNuevoPedido.RowCount > 0)
                    //{
                        dgvNuevoPedido.Rows.RemoveAt(dgvNuevoPedido.CurrentRow.Index);

                        for (int i = 0; i < dgvNuevoPedido.RowCount; i++)
                        {
                            this.t = this.t + (float.Parse(dgvNuevoPedido.Rows[i].Cells[1].Value.ToString()) * float.Parse(dgvNuevoPedido.Rows[i].Cells[2].Value.ToString()));
                        }
                        txtTotal.Text = Convert.ToString(t);
                        dgvNuevoPedido.ClearSelection();
                    //}
                }
                else
                {
                    MessageBox.Show("Error, Selecciona el producto a quitar del pedido");
                }
            }
            else
            {
                MessageBox.Show("Error, Selecciona el producto a quitar del pedido");
            }
        }
    }
}
