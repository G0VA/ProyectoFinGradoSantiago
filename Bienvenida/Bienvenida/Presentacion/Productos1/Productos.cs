using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Bienvenida.Presentacion.Principal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bienvenida.Dominio;

namespace Bienvenida.Presentacion.Productos
{
    public partial class Productos : Form
    {

        private Principal.Principal prin;
        Pedidos.NuevoPedido observer;
        Pedidos.ModificaPedido modObserver;

        public Productos(Principal.Principal prin)
        {
            InitializeComponent();
            this.prin = prin;
            initTipo1("");
            initTable("");
            dgvProductos.ClearSelection();
            btnVolver.Visible = false;
        }

        public Productos(Pedidos.NuevoPedido nuevo)
        {
            this.observer = nuevo;
            InitializeComponent();
            initTipo1("");
            initTable("");
            dgvProductos.ClearSelection();

            btnAñadir.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnCerrar.Visible = false;
        }

        public Productos(Pedidos.ModificaPedido nuevo)
        {
            this.modObserver = nuevo;
            InitializeComponent();
            initTipo1("");
            initTable("");
            dgvProductos.ClearSelection();

            btnAñadir.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnCerrar.Visible = false;
        }

        public void initTable(String cond)
        {
            dgvProductos.Columns.Clear();

            Producto p = new Producto();
            p.getGestor().leerProductos(cond);


            DataTable tcustomers = p.getGestor().getTabla();
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add("ID_PRODUCTO", "ID");
            dgvProductos.Columns.Add("NOMBRE_PRODUCTO", "NOMBRE_PRODUCTO");
            dgvProductos.Columns.Add("TIPO1", "TIPO1");
            dgvProductos.Columns.Add("TIPO2", "TIPO2");
            dgvProductos.Columns.Add("STOCK", "STOCK");
            dgvProductos.Columns.Add("PRECIO", "PRECIO");

            foreach (DataRow row in tcustomers.Rows)
            {
                dgvProductos.Rows.Add(row["ID_PRODUCTO"], row["NOMBRE_PRODUCTO"], row["TIPO1"], row["TIPO2"], row["STOCK"], row["PRECIO"]);
            }
            this.dgvProductos.Columns["ID_PRODUCTO"].Visible = false;

            dgvProductos.ClearSelection();

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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevo = new NuevoProducto(this);
            this.Hide();
            nuevo.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            prin.mideStock();
            this.prin.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool n = dgvProductos.CurrentRow.Selected;
            if (n)
            {
                ProductoDto p = new ProductoDto();
                p.setId(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString());
                p.setNombre(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString());
                p.setT1(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2].Value.ToString());
                p.setT2(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[3].Value.ToString());
                p.setStock(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[4].Value.ToString());
                p.setPrecio(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[5].Value.ToString());

                ModificarProducto modificar = new ModificarProducto(this, p);
                dgvProductos.ClearSelection();
                this.Hide();
                modificar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error, Selecciona el producto a modificar");
            }

        }

        private void cambioValor(object sender, EventArgs e)
        {
            if (cbTipo1.SelectedIndex != -1)
            {
                cbTipo2.Items.Clear();
                String cond = " Where t1 = (Select id from PRODUCTOS_TIPO1 where TIPO = '" + cbTipo1.SelectedItem.ToString() + "')";
                initTipo2(cond);
            }  
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String sql = "";

            if (!String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")))
            {
                sql += " And Upper(p.NOMBRE_PRODUCTO) like '%" + txtNombre.Text.ToUpper().Replace("'", "") + "%' ";
            }

            if (cbTipo1.SelectedIndex != -1)
            {
                sql += " And Upper(t1.TIPO) like '%" + cbTipo1.SelectedItem.ToString().Replace("'", "") + "%' ";
            }

            if (cbTipo2.SelectedIndex != -1)
            {
                sql += " And Upper(t2.TIPO) like '%" + cbTipo2.SelectedItem.ToString().Replace("'", "") + "%' ";
            }

            initTable(sql);
        }

        private void mostrar(object sender, EventArgs e)
        {
            dgvProductos.ClearSelection();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            cbTipo1.SelectedIndex = -1;
            cbTipo2.Items.Clear();
            initTable("");
            //initTipo1("");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            bool n = dgvProductos.CurrentRow.Selected;
            if (n)
            {
                Producto p = new Producto();
                String id = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString();
                String sql = "Update productos set borrado=1 where id_producto=" + id;

                if (MessageBox.Show("¿Quieres eliminar a este producto?", "Eliminar Pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    p.getGestor().setData(sql);
                    MessageBox.Show("Producto eliminado con exito");
                    initTable("");
                }
            }
            else
            {
                MessageBox.Show("Error, selecciona un producto");
                dgvProductos.ClearSelection();


            }
        }

        

        private void Coger(object sender, DataGridViewCellEventArgs e)
        {
            String id = (dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString() == null) ? "" : dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString();
            String nombre = (dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString() == null) ? "" : dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString();
            String t1 = (dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2].Value.ToString() == null) ? "" : dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2].Value.ToString();
            String t2 = (dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[3].Value.ToString() == null) ? "" : dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[3].Value.ToString();
            String stock = (dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[4].Value.ToString() == null) ? "" : dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[4].Value.ToString();
            String precio = (dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[5].Value.ToString() == null) ? "" : dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[5].Value.ToString();

            ProductoDto producto = new ProductoDto(id, nombre, t1, t2, stock, precio);
            if (observer != null)
            {
                observer.updateProducto(producto);
                Dispose();
                observer.Show();
            }

            if (modObserver != null)
            {
                modObserver.updateProducto(producto);
                Dispose();
                modObserver.Show();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();

            if (observer != null)
            {
                observer.Show();
            }
            if (modObserver != null)
            {
                modObserver.Show();
            }
        }

        private void cbTipo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTipo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
