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
        ProductoDto p;
        public ModificarProducto(Productos pro, ProductoDto p)
        {
            this.pro = pro;
            InitializeComponent();
            this.p = p;
            initTipo1("");
            llenaCampos();
        }

        public void llenaCampos()
        {
            txtNombre.Text = p.getNombre();
            txtPrecio.Text = p.getPrecio();
            txtStock.Text = p.getStock();
            //cbTipo1.SelectedText = p.getT1().ToUpper();
            //cbTipo2.SelectedText = p.getT2().ToUpper();

            //Producto pro = new Producto();
            //String t1Texto = pro.getGestor().getUnString("select id from productos_tipo1 where tipo = '" + cbTipo1.SelectedItem.ToString() + "'");
            //String t2Texto = pro.getGestor().getUnString("select id from productos_tipo2 where tipo = '" + cbTipo2.SelectedItem.ToString() + "'");
            //int t1 = Int16.Parse(t1Texto);
            //int t2 = Int16.Parse(t2Texto);
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

        public Boolean check()
        {
            Boolean correcto = true;

            if (String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")))
            {
                correcto = false;
            }

            if (cbTipo1.SelectedIndex == -1)
            {
                correcto = false;
            }

            if (cbTipo2.SelectedIndex == -1)
            {
                correcto = false;
            }

            if (String.IsNullOrEmpty(txtStock.Text.Replace("'", "")))
            {
                correcto = false;
            }

            if (String.IsNullOrEmpty(txtPrecio.Text.Replace("'", "")))
            {
                correcto = false;

            }

            return correcto;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (check())
            {
                Producto pro = new Producto();
                //String idTexto = pro.getGestor().getUnString("select count(*) from productos");
                //int id = Int16.Parse(idTexto);
                //id++;
                float precio = float.Parse(txtPrecio.Text.Replace("'", "").Replace(".", ",").ToString());
                String t1Texto = pro.getGestor().getUnString("select id from productos_tipo1 where tipo = '" + cbTipo1.SelectedItem.ToString() + "'");
                String t2Texto = pro.getGestor().getUnString("select id from productos_tipo2 where tipo = '" + cbTipo2.SelectedItem.ToString() + "'");
                int t1 = Int16.Parse(t1Texto);
                int t2 = Int16.Parse(t2Texto);

                String delete = "delete from productos where id_producto = "+this.p.getId();
                String sql = "INSERT INTO PRODUCTOS (ID_PRODUCTO, NOMBRE_PRODUCTO, TIPO1, TIPO2, STOCK, PRECIO, BORRADO) VALUES (" + this.p.getId() + ", '" + txtNombre.Text.Replace("'", "") + "', " + t1 + ", " + t2 + ", " + txtStock.Text.Replace("'", "") + ", '" + precio + "', 0)";

                pro.getGestor().setData(delete);
                pro.getGestor().setData(sql);

                MessageBox.Show("Insertado con éxito");

                this.pro.initTable("");
            }
            else
            {
                MessageBox.Show("Rellena todos los campos antes de añadir producto");
            }
        }
    }
}
