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

namespace Bienvenida.Presentacion.Principal1
{
    public partial class Contabilidad : Form
    {
        Principal.Principal prin;
        public Contabilidad(Principal.Principal prin)
        {
            this.prin = prin;
            InitializeComponent();
            lblCambio.Text = "MOSTRANDO CONTABILIDAD DEL ESTABLECIMIENTO";
            iniCombox();
            consultas("");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            prin.Show();
        }

        private void consultas(String emple)
        {
            if (cbEmple.SelectedIndex != -1)
            {
                Pedido p = new Pedido();
                String idEmple = p.getGestor().getUnString("select id_emple from empleados where dni = '"+emple+"'");

                DateTime hoy = DateTime.Today;
                String dia = p.getGestor().getUnString("select sum(total) from pedidos where ref_emple = " + idEmple + " and pagado = 1 and trunc(fecha_pedido) = to_date('" + hoy.ToString("d") + "','dd/MM/yyyy')");
                String mes = p.getGestor().getUnString("select sum(total) from pedidos where ref_emple = " + idEmple + " and pagado = 1 and to_char(fecha_pedido, 'MM') = to_char(sysdate, 'MM')");
                String ano = p.getGestor().getUnString("select sum(total) from pedidos where ref_emple = " + idEmple + " and pagado = 1 and to_char(fecha_pedido, 'yyyy') = to_char(sysdate, 'yyyy')");
                if (String.IsNullOrEmpty(dia))
                    dia = "0";
                if (String.IsNullOrEmpty(mes))
                    mes = "0";
                if (String.IsNullOrEmpty(ano))
                    ano = "0";
                txtVentaHoy.Text = dia + "€";
                txtVentaMes.Text = mes + "€";
                txtVentaAno.Text = ano + "€";

                if (ckDate.Checked && ckDate2.Checked)
                {
                    lblDias.Text = "Total vendido rango de dias elegido______";

                    String elegido = p.getGestor().getUnString("select sum(total) from pedidos where ref_emple = " + idEmple + " and pagado = 1 and trunc(fecha_pedido) between to_date('" + date.Text.Replace("'", "") + "','dd/MM/yyyy') and to_date('" + date2.Text.Replace("'", "") + "','dd/MM/yyyy')");
                    if (String.IsNullOrEmpty(elegido))
                        elegido = "0";
                    txtVentaElegido.Text = elegido + "€";
                }
                else if (ckDate.Checked)
                {
                    lblDias.Text = "Total vendido dia elegido_______________";

                    String elegido = p.getGestor().getUnString("select sum(total) from pedidos where ref_emple = "+ idEmple+" and pagado = 1 and trunc(fecha_pedido) = to_date('" + date.Text.Replace("'", "") + "','dd/MM/yyyy')");
                    if (String.IsNullOrEmpty(elegido))
                        elegido = "0";
                    txtVentaElegido.Text = elegido + "€";
                }
            }
            else
            {
                Pedido p = new Pedido();
                DateTime hoy = DateTime.Today;
                String dia = p.getGestor().getUnString("select sum(total) from pedidos where pagado = 1 and trunc(fecha_pedido) = to_date('" + hoy.ToString("d") + "','dd/MM/yyyy')");
                String mes = p.getGestor().getUnString("select sum(total) from pedidos where pagado = 1 and to_char(fecha_pedido, 'MM') = to_char(sysdate, 'MM')");
                String ano = p.getGestor().getUnString("select sum(total) from pedidos where pagado = 1 and to_char(fecha_pedido, 'yyyy') = to_char(sysdate, 'yyyy')");
                if (String.IsNullOrEmpty(dia))
                    dia = "0";
                if (String.IsNullOrEmpty(mes))
                    mes = "0";
                if (String.IsNullOrEmpty(ano))
                    ano = "0";
                txtVentaHoy.Text = dia + "€";
                txtVentaMes.Text = mes + "€";
                txtVentaAno.Text = ano + "€";

                if(ckDate.Checked && ckDate2.Checked)
                {
                    lblDias.Text = "Total vendido periodo de dias elegido______";

                    String elegido = p.getGestor().getUnString("select sum(total) from pedidos where pagado = 1 and trunc(fecha_pedido) between to_date('" + date.Text.Replace("'", "") + "','dd/MM/yyyy') and to_date('" + date2.Text.Replace("'", "") + "','dd/MM/yyyy')");
                    if (String.IsNullOrEmpty(elegido))
                        elegido = "0";
                    txtVentaElegido.Text = elegido + "€";
                }
                else if (ckDate.Checked)
                {
                    lblDias.Text = "Total vendido dia elegido_______________";

                    String elegido = p.getGestor().getUnString("select sum(total) from pedidos where pagado = 1 and trunc(fecha_pedido) = to_date('" + date.Text.Replace("'", "") + "','dd/MM/yyyy')");
                    if (String.IsNullOrEmpty(elegido))
                        elegido = "0";
                    txtVentaElegido.Text = elegido + "€";
                }
            }
        }

        private void iniCombox()
        {
            Usuario user = new Usuario();
            user.gestor().readInDB("DNI", "empleados", "where borrado = 0");
            DataTable tipo1 = user.gestor().getTabla();
            cbEmple.Items.Clear();
            foreach (DataRow row in tipo1.Rows)
            {
                cbEmple.Items.Add(row["DNI"]);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbEmple.SelectedIndex != -1)
            {
                lblCambio.Text = "MOSTRANDO CONTABILIDAD DE: " + cbEmple.SelectedItem.ToString().Replace("'", "");
                consultas(cbEmple.SelectedItem.ToString().Replace("'", ""));
            }
            else
            {
                consultas("");
            }           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbEmple.SelectedIndex = -1;
            ckDate.Checked = false;
            lblDias.Text = "";
            lblCambio.Text = "MOSTRANDO CONTABILIDAD DEL ESTABLECIMIENTO";
            txtVentaElegido.Text = "";
            consultas("");
        }

        private void cambioCk1(object sender, EventArgs e)
        {
            if (!ckDate.Checked)
            {
                ckDate2.Checked = false;
                ckDate2.Enabled = false;
                date.Enabled = false;
            }
            else
            {
                date.Enabled = true;
                ckDate2.Enabled = true;
            }
        }

        private void cambioCk2(object sender, EventArgs e)
        {
            if (!ckDate2.Checked)
            {
                date2.Enabled = false;
            }
            else
            {
                date2.Enabled = true;
            }
        }
    }
}
