﻿using System;
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


        public Productos(Principal.Principal prin)
        {
            InitializeComponent();
            this.prin = prin;
            initTipo1("");
            initTable("");
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
            this.prin.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarProducto modificar = new ModificarProducto(this);
            this.Hide();
            modificar.ShowDialog();
        }

        private void cambioValor(object sender, EventArgs e)
        {
            cbTipo2.Items.Clear();
            String cond = " Where t1 = (Select id from PRODUCTOS_TIPO1 where TIPO = '" + cbTipo1.SelectedItem.ToString() + "')";
            initTipo2(cond);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String sql = "";

            if(!String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")))
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
            cbTipo1.Items.Clear();
            cbTipo1.SelectedIndex = -1;
            cbTipo2.Items.Clear();
            cbTipo2.SelectedIndex = -1;
            initTable("");
            initTipo1("");
        }
    }
}
