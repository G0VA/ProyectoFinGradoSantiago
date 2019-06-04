using Bienvenida.Dominio;
using Bienvenida.Presentacion.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenida.Presentacion.Productos1
{
    public partial class CreaCategoria : Form
    {
        private ModificarProducto mod;
        private NuevoProducto nue;
        public CreaCategoria(NuevoProducto nue)
        {
            this.nue = nue;
            InitializeComponent();
            initTipo1("");
        }

        public CreaCategoria(ModificarProducto mod)
        {
            this.mod = mod;
            InitializeComponent();
            initTipo1("");
        }

        public void initTipo1(String cond)
        {
            Producto p = new Producto();
            p.getGestor().readInDB("TIPO", "PRODUCTOS_TIPO1", cond);
            DataTable tipo1 = p.getGestor().getTabla();
            foreach (DataRow row in tipo1.Rows)
            {
                cbTipo1.Items.Add(row["TIPO"]);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if(mod!= null)
            {
                mod.Show();
            }else
            {
                nue.Show();
            }
        }

        private Boolean check()
        {
            Boolean correcto = true;

            if (cbTipo1.SelectedIndex == -1)
            {
                correcto = false;
            }

            if (String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")))
            {
                correcto = false;
            }

            return correcto;
        }

        private Boolean existeTipo(String nombre,int t1)
        {
            Boolean existe = false;
            Producto p = new Producto();
            int count = Int16.Parse(p.getGestor().getUnString("select count(*) from productos_tipo2 where upper(tipo) = '" + nombre.ToUpper() + "' and t1 = "+t1));
            if (count > 0)
                existe = true;

            return existe;

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (check())
            {
                Producto p = new Producto();
                int idTipo1 = Int16.Parse(p.getGestor().getUnString("select id from productos_tipo1 where tipo = '" + cbTipo1.SelectedItem.ToString().Replace("'", "") + "'"));
                int count = Int16.Parse(p.getGestor().getUnString("select count(*) from productos_tipo2"));
                if (!existeTipo(txtNombre.Text.Replace("'", ""),idTipo1))
                {
                    count++;
                    p.getGestor().setData("insert into productos_tipo2 (ID,TIPO,T1) values (" + count + ",'" + txtNombre.Text.Replace("'", "").ToUpper() + "',"+idTipo1+")");
                    this.Dispose();
                    if (mod != null)
                    {
                        mod.Show();
                    }
                    else
                    {
                        nue.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe esa categoria");
                }    
            }
            else
            {
                MessageBox.Show("Error, revisa los datos");
            }
            
        }
    }
}
