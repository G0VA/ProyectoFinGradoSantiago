using Bienvenida.Dominio;
using Bienvenida.Presentacion.Productos1;
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
            cbTipo1.Items.Clear();
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

            if (String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")) || txtNombre.Text.Replace("'", "").Length > 40)
            {
                if (txtNombre.Text.Replace("'", "").Length > 40)
                    MessageBox.Show("Campo nombre demasiado grande", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            if (String.IsNullOrEmpty(txtStock.Text.Replace("'", "")) || txtStock.Text.Replace("'", "").Length > 7)
            {
                if (txtStock.Text.Replace("'", "").Length > 7)
                    MessageBox.Show("Campo stock demasiado grande", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                correcto = false;
                return correcto;
            }

            if (String.IsNullOrEmpty(txtPrecio.Text.Replace("'", "")) || txtPrecio.Text.IndexOf(".") > 7 || txtPrecio.Text.Replace("'", "").Length > 7)
            {
                if (txtPrecio.Text.IndexOf(".") > 7 || txtPrecio.Text.Replace("'", "").Length > 7)
                    MessageBox.Show("Campo precio demasiado grande", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                correcto = false;

            }

            return correcto;

        }

        private Boolean existeProduct(String nombre)
        {
            Boolean existe = false;
            Producto p = new Producto();
            int count = Int16.Parse(p.getGestor().getUnString("select count(*) from productos where borrado = 0 and upper(nombre_producto) = '" + nombre.ToUpper() + "'"));
            if (count > 1)
                existe = true;

            return existe;

        }

        private Boolean existeTipo(String nombre)
        {
            Boolean existe = false;
            Producto p = new Producto();
            int count = Int16.Parse(p.getGestor().getUnString("select count(*) from productos_tipo1 where upper(tipo) = '" + nombre.ToUpper() + "'"));
            if (count > 0)
                existe = true;

            return existe;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (check())
            {
                Producto prod = new Producto();
                //String idTexto = pro.getGestor().getUnString("select count(*) from productos");
                //int id = Int16.Parse(idTexto);
                //id++;
                float precio = float.Parse(txtPrecio.Text.Replace("'", "").Replace(".", ",").ToString());
                String t1Texto = prod.getGestor().getUnString("select id from productos_tipo1 where tipo = '" + cbTipo1.SelectedItem.ToString() + "'");
                String t2Texto = prod.getGestor().getUnString("select id from productos_tipo2 where tipo = '" + cbTipo2.SelectedItem.ToString() + "'");
                int t1 = Int16.Parse(t1Texto);
                int t2 = Int16.Parse(t2Texto);

                //String delete = "delete from productos where id_producto = "+this.p.getId();
 
                //String sql = "INSERT INTO PRODUCTOS (ID_PRODUCTO, NOMBRE_PRODUCTO, TIPO1, TIPO2, STOCK, PRECIO, BORRADO, AVISADO) VALUES (" + this.p.getId() + ", '" + txtNombre.Text.Replace("'", "") + "', " + t1 + ", " + t2 + ", " + txtStock.Text.Replace("'", "") + ", '" + precio + "', 0, 0)";
                String update = "update productos set TIPO1 = "+ t1+", TIPO2 = "+t2+", STOCK = " + txtStock.Text.Replace("'", "") + ", PRECIO = '"+precio+"', AVISADO = 0 where id_producto = "+ this.p.getId();
                prod.getGestor().setData(update);
                //pro.getGestor().setData(sql);

                MessageBox.Show("Modificado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Dispose();
                this.pro.initTable("");
                this.pro.Show();
                
            }
            else
            {
                MessageBox.Show("Rellena todos los campos antes de añadir producto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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

        private void btnCreaTipo1_Click(object sender, EventArgs e)
        {
            string categoria = Microsoft.VisualBasic.Interaction.InputBox("Introducir nueva categoria");
            if (!String.IsNullOrEmpty(categoria))
            {
                if (!existeTipo(categoria))
                {
                    Producto prod = new Producto();
                    int count = Int16.Parse(prod.getGestor().getUnString("select count(*) from productos_tipo1"));
                    count++;
                    prod.getGestor().setData("insert into productos_tipo1 (ID,TIPO) values (" + count + ",'" + categoria.ToUpper() + "')");
                    initTipo1("" + " order by id");
                    cbTipo2.SelectedIndex = -1;
                    MessageBox.Show("Categoria insertada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Ya existe el categoria", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puede estar vacio, no insertado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreaTipo2_Click(object sender, EventArgs e)
        {
            CreaCategoria crea = new CreaCategoria(this);
            this.Hide();
            crea.ShowDialog();
        }
    }
}
