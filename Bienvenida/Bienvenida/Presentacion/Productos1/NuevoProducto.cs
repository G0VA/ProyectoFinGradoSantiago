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
    public partial class NuevoProducto : Form
    {
        Productos pro;
        public NuevoProducto(Productos pro)
        {
            this.pro = pro;
            InitializeComponent();
            initTipo1(""+" order by id");
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
            initTipo2(cond + " order by id");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.pro.Show();
        }

        public Boolean check()
        {
            Boolean correcto = true;

            if(String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")))
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

        private Boolean existeProduct(String nombre)
        {
            Boolean existe = false;
            Producto p = new Producto();
            int count = Int16.Parse(p.getGestor().getUnString("select count(*) from productos where upper(nombre_producto) = '" + nombre.ToUpper() + "'"));
            if (count > 0)
                existe = true;

            return existe;

        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (!existeProduct(txtNombre.Text.Replace("'", "")))
                {
                    Producto p = new Producto();
                    String idTexto = p.getGestor().getUnString("select count(*) from productos");
                    int id = Int16.Parse(idTexto);
                    id++;
                    float precio = float.Parse(txtPrecio.Text.Replace("'", "").Replace(".", ",").ToString());
                    String t1Texto = p.getGestor().getUnString("select id from productos_tipo1 where tipo = '" + cbTipo1.SelectedItem.ToString() + "'");
                    String t2Texto = p.getGestor().getUnString("select id from productos_tipo2 where tipo = '" + cbTipo2.SelectedItem.ToString() + "'");
                    int t1 = Int16.Parse(t1Texto);
                    int t2 = Int16.Parse(t2Texto);

                    String sql = "INSERT INTO PRODUCTOS (ID_PRODUCTO, NOMBRE_PRODUCTO, TIPO1, TIPO2, STOCK, PRECIO, BORRADO, AVISADO) VALUES (" + id + ", '" + txtNombre.Text.Replace("'", "") + "', " + t1 + ", " + t2 + ", " + txtStock.Text.Replace("'", "") + ", '" + precio + "', 0, 0)";

                    p.getGestor().setData(sql);

                    MessageBox.Show("Insertado con éxito");

                    this.Dispose();
                    this.pro.initTable("");
                    this.pro.Show();
                }else
                {
                    MessageBox.Show("Ya existe el producto");
                }  
            }
            else
            {
                MessageBox.Show("Rellena todos los campos antes de añadir producto");
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Contains('.'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
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
