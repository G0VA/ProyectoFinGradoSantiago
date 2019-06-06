using Bienvenida.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenida.Presentacion.Pedidos.Ticket
{
    public partial class PintaRecibo : Form
    {
        private int idEmple;
        private int idPedido;
        public PintaRecibo(int idEmple, int idPedido)
        {
            InitializeComponent();
            this.idEmple = idEmple;
            this.idPedido = idPedido;
        }

        private DataTable llenaPedido()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();
            DataTable tcustomers = new DataTable();

            tcustomers.Columns.Add("id", Type.GetType("System.String"));
            tcustomers.Columns.Add("fecha", Type.GetType("System.String"));
            tcustomers.Columns.Add("total", Type.GetType("System.String"));
            tcustomers.Columns.Add("pago", Type.GetType("System.String"));
            tcustomers.Columns.Add("iva", Type.GetType("System.String"));

            data = search.getData("select o.id_pedido id, o.fecha_pedido fecha, o.total, f.forma_pago pago from pedidos o inner join FORMAS_PAGO f on f.ID_FPAGO = o.REF_PAGO where o.ID_PEDIDO = " + idPedido, "exam");
            DataTable tmp = data.Tables["exam"];

            double total = double.Parse(search.getData("select total from pedidos where id_pedido = "+idPedido));
            double iva = (total * 0.21);
            iva = Math.Round(iva, 2);
            foreach (DataRow row in tmp.Rows)
            {
                
                tcustomers.Rows.Add(new Object[] { row["id"], row["fecha"], total.ToString(), row["pago"], iva .ToString()});
            }

            return tcustomers;
        }

        private DataTable llenaEmple()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();
            DataTable tcustomers = new DataTable();

            tcustomers.Columns.Add("dni", Type.GetType("System.String"));
            tcustomers.Columns.Add("nombre", Type.GetType("System.String"));
            tcustomers.Columns.Add("apellido", Type.GetType("System.String"));

            data = search.getData("select dni, nombre, apellidos apellido from empleados where ID_EMPLE = " + idEmple, "exam");
            DataTable tmp = data.Tables["exam"];

            foreach (DataRow row in tmp.Rows)
            {
                tcustomers.Rows.Add(new Object[] { row["dni"], row["nombre"], row["apellido"] });
            }

            return tcustomers;
        }

        private DataTable llenaPro()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();
            DataTable tcustomers = new DataTable();

            tcustomers.Columns.Add("cantidad", Type.GetType("System.String"));
            tcustomers.Columns.Add("nombre", Type.GetType("System.String"));
            tcustomers.Columns.Add("precio", Type.GetType("System.String"));
            tcustomers.Columns.Add("total", Type.GetType("System.String"));

            String sql1 = "select o.cantidad, p.nombre_producto nombre, o.precio, (o.cantidad * p.precio) total from pedidos_productos o inner join productos p on p.ID_PRODUCTO = o.ref_producto where o.ref_pedido = " + idPedido;

            data = search.getData(sql1, "exam");
            DataTable tmp = data.Tables["exam"];

            foreach (DataRow row in tmp.Rows)
            {
                tcustomers.Rows.Add(new Object[] { row["cantidad"], row["nombre"], row["precio"], row["total"] });
            }

            return tcustomers;
        }

        private new void Load(object sender, EventArgs e)
        {
            DataTable tPedido = llenaPedido();
            DataTable tEmple = llenaEmple();
            DataTable tproduc = llenaPro();

            CrystalReportRecibo1 reporte = new CrystalReportRecibo1();
            reporte.Database.Tables["Pedido"].SetDataSource(tPedido);
            reporte.Database.Tables["Empleado"].SetDataSource(tEmple);
            reporte.Database.Tables["Producto"].SetDataSource(tproduc);

            

            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
