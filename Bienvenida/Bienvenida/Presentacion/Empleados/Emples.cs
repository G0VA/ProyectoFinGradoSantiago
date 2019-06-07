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

namespace Bienvenida.Presentacion.Empleados
{
    public partial class Emples : Form
    {
        private InicioApp ini;
        public Emples(InicioApp ini)
        {
            this.ini = ini;
            InitializeComponent();
            initTable("");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ini.Show();
        }

        public void initTable(String cond)
        {
            dgvEmples.Columns.Clear();

            Usuario u = new Usuario();
            u.gestor().leerUsers(cond);


            DataTable tcustomers = u.gestor().getTabla();
            dgvEmples.Columns.Clear();

            dgvEmples.Columns.Add("DNI", "DNI");
            dgvEmples.Columns.Add("NOMBRE", "NOMBRE");


            foreach (DataRow row in tcustomers.Rows)
            {
                dgvEmples.Rows.Add(row["DNI"], row["NOMBRE"]);
            }

            dgvEmples.ClearSelection();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            initTable("");
        }

        private void mostrar(object sender, EventArgs e)
        {
            dgvEmples.ClearSelection();
        }
        private Boolean existeEmpleActivo()
        {
            Boolean existe = false;
            Producto p = new Producto();
            int count = Int16.Parse(p.getGestor().getUnString("select count(*) from PEDIDOS p inner join Empleados e on e.ID_EMPLE = p.REF_EMPLE where p.PAGADO = 0 and e.DNI = '"+ dgvEmples.Rows[dgvEmples.CurrentRow.Index].Cells[0].Value.ToString() + "'"));
            if (count > 0)
                existe = true;

            return existe;

        }

        private Boolean existeEmpleLog()
        {
            Boolean existe = false;
            Producto p = new Producto();
            int count = Int16.Parse(p.getGestor().getUnString("select count(*) from Empleados where conectado = 1 and DNI = '" + dgvEmples.Rows[dgvEmples.CurrentRow.Index].Cells[0].Value.ToString() + "'"));
            if (count > 0)
                existe = true;

            return existe;

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String sql = "";

            if (!String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")))
            {
                sql += " And Upper(DNI) like '%" + txtNombre.Text.ToUpper().Replace("'", "") + "%' ";
            }
            initTable(sql);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            bool n = dgvEmples.CurrentRow.Selected;
            if (n)
            {
                if(!existeEmpleActivo() && !existeEmpleLog())
                {
                    Usuario u = new Usuario();
                    String dni = dgvEmples.Rows[dgvEmples.CurrentRow.Index].Cells[0].Value.ToString();
                    String sql = "Update empleados set borrado=1 where dni='" + dni + "'";

                    if (MessageBox.Show("¿Quieres dar de baja a este empleado?", "Eliminar Pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        u.gestor().setData(sql);
                        MessageBox.Show("Empleado dado de baja con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        initTable("");
                    }
                }
                else
                {
                    if(!existeEmpleActivo())
                        MessageBox.Show("Error, el empleado seleccionado esta actualmente con sesion iniciada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Error, el empleado seleccionado tiene pedidos activos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Error, selecciona un empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvEmples.ClearSelection();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            AddEmple addEmple = new AddEmple(this);
            this.Hide();
            addEmple.ShowDialog();
        }
    }
}
