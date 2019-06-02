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
    public partial class ModificaPedido : Form
    {
        Principal.Principal prin;
        PedidoDto pedidoDto;
        ProductoDto prod;
        private float t;
        public ModificaPedido(Principal.Principal prin, PedidoDto pedidoDto)
        {
            this.prin = prin;
            this.pedidoDto = pedidoDto;
            InitializeComponent();
            iniCombox();
            txtCliente.Text = pedidoDto.getCliente();
            txtDni.Text = pedidoDto.getDni() + " -- " +pedidoDto.getNombre();
            txtId.Text = pedidoDto.getId();
            txtTotal.Text = pedidoDto.getTotal();
            iniTable("and ref_pedido = "+pedidoDto.getId());
            sumaStock();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            iniTable("and ref_pedido = " + pedidoDto.getId());
            restaStock();
            prin.initTable("");
            this.Dispose();
            prin.Show();
            prin.mideStock();
        }

        private void iniCombox()
        {
            Pedido p = new Pedido();
            p.getGestor().readInDB("FORMA_PAGO", "FORMAS_PAGO", "");
            DataTable tipo2 = p.getGestor().getTabla();
            cbFPago.Items.Clear();
            foreach (DataRow row in tipo2.Rows)
            {
                cbFPago.Items.Add(row["FORMA_PAGO"]);
            }
        }
        private void iniTable(String cond)
        {
            dgvModPedido.Columns.Clear();

            Pedido p = new Pedido();
            p.getGestor().leerLineasPedidos(cond);


            DataTable tcustomers = p.getGestor().getTabla();
            dgvModPedido.Columns.Clear();

            dgvModPedido.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvModPedido.Columns.Add("CANTIDAD", "CANTIDAD");
            dgvModPedido.Columns.Add("PRECIO", "PRECIO");

            foreach (DataRow row in tcustomers.Rows)
            {
                dgvModPedido.Rows.Add(row["PRODUCTO"], row["CANTIDAD"], row["PRECIO"]);
            }

            dgvModPedido.ClearSelection();
        }

        private void ModificaPedido_Shown(object sender, EventArgs e)
        {
            dgvModPedido.ClearSelection();
        }

        public void updateProducto(ProductoDto producto)
        {
            this.prod = producto;
            txtProduct.Text = producto.getNombre();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Productos.Productos productos = new Productos.Productos(this);
            this.Hide();
            productos.ShowDialog();
            this.nudAmount.Value = 1;
        }
        private void sumaStock()
        {
            for (int i = 0; i < dgvModPedido.RowCount; i++)
            {
                Pedido o = new Pedido();

                String sql = "SELECT id_producto FROM productos WHERE UPPER(nombre_producto) = '" + dgvModPedido.Rows[i].Cells[0].Value.ToString().ToUpper() + "'";
                String idp = o.getGestor().getUnString(sql);

                int newStock = Int32.Parse(o.getGestor().getUnString("select stock from productos where id_producto = " + idp)) + Int32.Parse(dgvModPedido.Rows[i].Cells[1].Value.ToString());
                o.getGestor().setData("update productos set stock = " + newStock + " where id_producto = " + idp);
            }
        }

        private void restaStock()
        {
            for (int i = 0; i < dgvModPedido.RowCount; i++)
            {
                Pedido o = new Pedido();

                String sql = "SELECT id_producto FROM productos WHERE UPPER(nombre_producto) = '" + dgvModPedido.Rows[i].Cells[0].Value.ToString().ToUpper() + "'";
                String idp = o.getGestor().getUnString(sql);

                int newStock = Int32.Parse(o.getGestor().getUnString("select stock from productos where id_producto = " + idp)) - Int32.Parse(dgvModPedido.Rows[i].Cells[1].Value.ToString());
                o.getGestor().setData("update productos set stock = " + newStock + " where id_producto = " + idp);
            }
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

                    for (int i = 0; i < dgvModPedido.RowCount && seguir; i++)
                    {
                        if (dgvModPedido.RowCount > 0)
                        {
                            String nombre = dgvModPedido.Rows[i].Cells[0].Value.ToString();
                            int amount = Int32.Parse(dgvModPedido.Rows[i].Cells[1].Value.ToString());

                            if (String.Equals(nombre, txtProduct.Text.Replace("'", "")))
                            {
                                seguir = false;
                                int newamount = amount + Int32.Parse(nudAmount.Value.ToString());
                                dgvModPedido.Rows[i].Cells[1].Value = newamount;
                                for (int j = 0; j < dgvModPedido.RowCount; j++)
                                {
                                    this.t = this.t + (float.Parse(dgvModPedido.Rows[j].Cells[1].Value.ToString()) * float.Parse(dgvModPedido.Rows[j].Cells[2].Value.ToString()));
                                }
                                txtTotal.Text = Convert.ToString(t);
                                dgvModPedido.ClearSelection();
                                txtProduct.Text = "";
                            }
                        }
                    }
                    if (seguir)
                    {
                        dgvModPedido.Rows.Add(txtProduct.Text.Replace("'", ""), nudAmount.Value.ToString().Replace("'", ""), prod.getPrecio().Replace("'", ""));

                        for (int i = 0; i < dgvModPedido.RowCount; i++)
                        {
                            this.t = this.t + (float.Parse(dgvModPedido.Rows[i].Cells[1].Value.ToString()) * float.Parse(dgvModPedido.Rows[i].Cells[2].Value.ToString()));
                        }
                        txtTotal.Text = Convert.ToString(t);
                        dgvModPedido.ClearSelection();
                        txtProduct.Text = "";
                    }
                    //dgvModPedido.Rows.Add(txtProduct.Text.Replace("'", ""), nudAmount.Value.ToString().Replace("'", ""), prod.getPrecio().Replace("'", ""));

                    //for (int i = 0; i < dgvModPedido.RowCount; i++)
                    //{
                    //     this.t = this.t + (float.Parse(dgvModPedido.Rows[i].Cells[1].Value.ToString()) * float.Parse(dgvModPedido.Rows[i].Cells[2].Value.ToString()));
                    //}
                    //txtTotal.Text = Convert.ToString(t);
                    //dgvModPedido.ClearSelection();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvModPedido.RowCount > 0)
            {
                bool n = dgvModPedido.CurrentRow.Selected;
                if (n)
                {
                    this.t = 0;
                    // if (dgvNuevoPedido.RowCount > 0)
                    //{
                    dgvModPedido.Rows.RemoveAt(dgvModPedido.CurrentRow.Index);

                    for (int i = 0; i < dgvModPedido.RowCount; i++)
                    {
                        this.t = this.t + (float.Parse(dgvModPedido.Rows[i].Cells[1].Value.ToString()) * float.Parse(dgvModPedido.Rows[i].Cells[2].Value.ToString()));
                    }
                    txtTotal.Text = Convert.ToString(t);
                    dgvModPedido.ClearSelection();
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

        private bool check()
        {
            bool correcto = true;

            if (cbFPago.SelectedIndex == -1)
                correcto = false;

            return correcto;

        }

        private void btnModificaPedido_Click(object sender, EventArgs e)
        {
            Pedido o = new Pedido();
            float f1 = -1;
            if (!txtTotal.Text.Equals(""))
            {
                f1 = float.Parse(txtTotal.Text.Replace("'", "").Replace(".", ",").ToString());
            }
            if (check() && (f1 != -1 && f1 > 0))
            {
                String id_pago = o.getGestor().getUnString("select id_fpago from formas_pago where forma_pago = '" + cbFPago.SelectedItem.ToString().Replace("'", "") + "'");
                o.getGestor().setData("update pedidos set ref_cliente = '"+txtCliente.Text.Replace("'", "")+"', ref_pago = '"+id_pago+"', total = '"+f1+"', fecha_pedido = sysdate where id_pedido = "+this.pedidoDto.getId());

                o.getGestor().setData("delete from pedidos_productos where ref_pedido ="+this.pedidoDto.getId());

                String idorderp = o.getGestor().getUnString("SELECT MAX(id_pedido_produc) FROM pedidos_productos");
                int idorderpNum = 1;
                if (!idorderp.Equals(""))
                {
                    idorderpNum = Int32.Parse(idorderp);
                    idorderpNum++;
                }
                String sql;
                for (int i = 0; i < dgvModPedido.RowCount; i++)
                {
                    sql = "SELECT id_producto FROM productos WHERE UPPER(nombre_producto) = '" + dgvModPedido.Rows[i].Cells[0].Value.ToString().ToUpper() + "'";
                    String idp = o.getGestor().getUnString(sql);
                    sql = "Insert into pedidos_productos values ('" + idorderpNum + "', '" + this.pedidoDto.getId() + "', '" + idp + "', '" + float.Parse(dgvModPedido.Rows[i].Cells[1].Value.ToString()) + "', '" + float.Parse(dgvModPedido.Rows[i].Cells[2].Value.ToString()) + "')";
                    o.getGestor().setData(sql);
                    idorderpNum++;
                    int newStock = Int32.Parse(o.getGestor().getUnString("select stock from productos where id_producto = " + idp)) - Int32.Parse(dgvModPedido.Rows[i].Cells[1].Value.ToString());
                    o.getGestor().setData("update productos set stock = " + newStock + " where id_producto = " + idp);
                }
                this.Dispose();
                prin.initTable("");
                prin.Show();
                prin.mideStock();
            }
            else
            {
                MessageBox.Show("Error, revise los datos para modificar pedido");
            }
        }
    }
}
