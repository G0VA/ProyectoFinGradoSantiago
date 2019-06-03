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

        private bool check()
        {
            bool correcto = true;
            if (cbEmples.SelectedIndex == -1)
                correcto = false;

            if (cbFPago.SelectedIndex == -1)
                correcto = false;

            return correcto;

        }

        private void btnCreaPedido_Click(object sender, EventArgs e)
        {
            Pedido o = new Pedido();
            float f1=-1;
            if (!txtTotal.Text.Equals(""))
            {
                f1 = float.Parse(txtTotal.Text.Replace("'", "").Replace(".", ",").ToString());
            }
            if (check() && (f1 != -1 && f1 > 0))
            {
                String idPedidoText = o.getGestor().getUnString("select MAX(id_pedido) from pedidos");
                int idPedido = Int32.Parse(idPedidoText);
                idPedido++;
                String id_emple = o.getGestor().getUnString("select id_emple from empleados where dni = '"+ cbEmples.SelectedItem.ToString().Replace("'", "") + "'");
                String id_pago = o.getGestor().getUnString("select id_fpago from formas_pago where forma_pago = '" + cbFPago.SelectedItem.ToString().Replace("'", "") + "'");
                String sql = "Insert into pedidos values (" + idPedido + ", " + id_emple + ", '" + txtCliente.Text.Replace("'", "") + "', " + id_pago + ", '" + f1 + "',0 , 0, sysdate)";
                o.getGestor().setData(sql);

                sql = "SELECT MAX(id_pedido_produc) FROM pedidos_productos";
                String idorderp = o.getGestor().getUnString(sql);
                int idorderpNum = 1;
                if (!idorderp.Equals(""))
                {
                    idorderpNum = Int32.Parse(idorderp);
                    idorderpNum++;
                } 
                for (int i = 0; i < dgvNuevoPedido.RowCount; i++)
                {
                    sql = "SELECT id_producto FROM productos WHERE UPPER(nombre_producto) = '" + dgvNuevoPedido.Rows[i].Cells[0].Value.ToString().ToUpper() + "'";
                    String idp = o.getGestor().getUnString(sql);
                    sql = "Insert into pedidos_productos values ('" + idorderpNum + "', '" + idPedido + "', '" + idp + "', '" + float.Parse(dgvNuevoPedido.Rows[i].Cells[1].Value.ToString()) + "', '" + float.Parse(dgvNuevoPedido.Rows[i].Cells[2].Value.ToString()) + "')";
                    o.getGestor().setData(sql);
                    idorderpNum++;
                    int newStock = Int32.Parse(o.getGestor().getUnString("select stock from productos where id_producto = " + idp)) - Int32.Parse(dgvNuevoPedido.Rows[i].Cells[1].Value.ToString());
                    o.getGestor().setData("update productos set stock = "+newStock+" where id_producto = "+idp);

                }
                this.Dispose();
                prin.initTable("");
                prin.Show();
                prin.mideStock();

            }
            else
            {
                MessageBox.Show("Error, revise los datos para crear pedido");
            }
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
            prin.mideStock();
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
                    bool seguir = true;

                    for (int i = 0; i < dgvNuevoPedido.RowCount && seguir; i++)
                    {
                        if(dgvNuevoPedido.RowCount > 0)
                        {
                            String nombre = dgvNuevoPedido.Rows[i].Cells[0].Value.ToString();
                            int amount = Int32.Parse(dgvNuevoPedido.Rows[i].Cells[1].Value.ToString());

                            if (String.Equals(nombre, txtProduct.Text.Replace("'", "")))
                            {
                                seguir = false;
                                int newamount = amount + Int32.Parse(nudAmount.Value.ToString());
                                dgvNuevoPedido.Rows[i].Cells[1].Value = newamount;
                                for (int j = 0; j < dgvNuevoPedido.RowCount; j++)
                                {
                                    this.t = this.t + (float.Parse(dgvNuevoPedido.Rows[j].Cells[1].Value.ToString()) * float.Parse(dgvNuevoPedido.Rows[j].Cells[2].Value.ToString()));
                                }
                                Math.Round(t, 2);
                                txtTotal.Text = Convert.ToString(t);
                                dgvNuevoPedido.ClearSelection();
                                txtProduct.Text = "";
                            }
                        }                      
                    }
                    if (seguir)
                    {
                        dgvNuevoPedido.Rows.Add(txtProduct.Text.Replace("'", ""), nudAmount.Value.ToString().Replace("'", ""), prod.getPrecio().Replace("'", ""));

                        for (int i = 0; i < dgvNuevoPedido.RowCount; i++)
                        {
                            this.t = this.t + (float.Parse(dgvNuevoPedido.Rows[i].Cells[1].Value.ToString()) * float.Parse(dgvNuevoPedido.Rows[i].Cells[2].Value.ToString()));
                        }
                        Math.Round(t, 2);
                        txtTotal.Text = Convert.ToString(t);
                        dgvNuevoPedido.ClearSelection();
                        txtProduct.Text = "";
                    }
                    
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
                        Math.Round(t, 2);
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

        private void cbEmples_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
