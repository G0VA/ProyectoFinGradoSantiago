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
using System.Windows.Forms.DataVisualization.Charting;

namespace Bienvenida.Presentacion.Principal1
{
    public partial class Grafico : Form
    {
        Contabilidad prin;
        int tipo;
        public Grafico(Contabilidad prin,int tipo)
        {
            this.prin = prin;
            this.tipo = tipo;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            prin.Show();
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            Pedido p = new Pedido();

            Usuario user = new Usuario();
            user.gestor().readInDB("DNI", "empleados", "where borrado = 0");
            DataTable tipo1 = user.gestor().getTabla();
            List<String> series = new List<string>();
            List<float> ventas = new List<float>();
            float total = 0;
            String aux = null;
            foreach (DataRow row in tipo1.Rows)
            {
                series.Add((row["DNI"].ToString()));

                String idEmple = p.getGestor().getUnString("select id_emple from empleados where dni = '" + row["DNI"].ToString() + "'");
                if (tipo == 1)
                {
                    aux = p.getGestor().getUnString("select sum(total) from pedidos where ref_emple = " + idEmple + " and pagado = 1 and to_char(fecha_pedido, 'dd') = to_char(sysdate, 'dd')");
                }else if(tipo == 2)
                {
                    aux = p.getGestor().getUnString("select sum(total) from pedidos where ref_emple = " + idEmple + " and pagado = 1 and to_char(fecha_pedido, 'MM') = to_char(sysdate, 'MM')");
                }
                else
                {
                    aux = p.getGestor().getUnString("select sum(total) from pedidos where ref_emple = " + idEmple + " and pagado = 1 and to_char(fecha_pedido, 'yyyy') = to_char(sysdate, 'yyyy')");
                }

                if (String.IsNullOrEmpty(aux))
                    aux = "0";
                total = total + float.Parse(aux);
                ventas.Add(float.Parse(aux));
            }

            if (tipo == 1)
            {
                chart1.Titles.Add("VENTAS "+ DateTime.Today.ToString("D")+ ", TOTAL----" + total + "€");
            }
            else if (tipo == 2)
            {
                chart1.Titles.Add("VENTAS " + DateTime.Today.ToString("Y") + ", TOTAL----" + total + "€");
            }
            else
            {
                chart1.Titles.Add("VENTAS " + DateTime.Today.ToString("yyyy") + ", TOTAL----" + total + "€");
            }
            

            for(int i = 0; i < series.Count; i++)
            {
                Series serie = chart1.Series.Add(series[i]);

                serie.Label = ventas[i].ToString() + "€";

                serie.Points.Add(ventas[i]);
            }
        }
    }
}
