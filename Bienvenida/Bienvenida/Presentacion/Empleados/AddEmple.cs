using Bienvenida.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenida.Presentacion.Empleados
{
    public partial class AddEmple : Form
    {
        private Emples emple;
        public AddEmple(Emples emple)
        {
            this.emple = emple;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.emple.Show();
        }
        public static bool checkDNI(String dni)
        {
            Regex regex = new Regex("[0-9]{8,8}[A-Za-z]");
            return regex.IsMatch(dni);
        }
        public Boolean check()
        {
            Boolean correcto = true;

            if (String.IsNullOrEmpty(txtNombre.Text.Replace("'", "")))
            {
                correcto = false;
            }

            if (String.IsNullOrEmpty(txtApe.Text.Replace("'", "")))
            {
                correcto = false;
            }

            if (String.IsNullOrEmpty(txtDni.Text.Replace("'", "")))
            {
                correcto = false;

            }else
            {
                if(!checkDNI(txtDni.Text.Replace("'", ""))){
                    correcto = false;
                    MessageBox.Show("DNI no valido. Formato valido XXXXXXXXA");
                    return correcto;
                }
            }


            if (String.IsNullOrEmpty(txtPass.Text.Replace("'", "")))
            {
                correcto = false;

            }

            if(!String.Equals(txtPass.Text.Replace("'", ""), txtPass2.Text.Replace("'", "")))
            {
                correcto = false;
                MessageBox.Show("Las contraseñas no coinciden");
            }

            return correcto;

        }

        private Boolean existeEmple(String dni)
        {
            Boolean existe = false;
            Usuario u = new Usuario();
            int count = Int16.Parse(u.gestor().getUnString("select count(*) from empleados where upper(dni) = '" + dni.ToUpper() + "'"));
            if (count > 0)
                existe = true;

            return existe;

        }

        private String encriptaPass(String pass)
        {
            string result = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(pass);
            result = Convert.ToBase64String(encryted);
            return result;
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (check())
            {

                if(!existeEmple(txtDni.Text.Replace("'", "")))
                {
                    String pass = encriptaPass(txtPass.Text.Replace("'", ""));

                    Usuario u = new Usuario();
                    String idTexto = u.gestor().getUnString("select count(*) from empleados");
                    int id = Int16.Parse(idTexto);
                    id++;

                    String sql = "insert into empleados (ID_EMPLE, NOMBRE, APELLIDOS, DNI, CONTRA, BORRADO, CONECTADO) VALUES (" + id + ", '" + txtNombre.Text.Replace("'", "") + "', '" + txtApe.Text.Replace("'", "") + "', '" + txtDni.Text.Replace("'", "") + "', '" + pass + "', 0, 0)";

                    u.gestor().setData(sql);

                    MessageBox.Show("Alta realizada correctamente");

                    this.emple.initTable("");
                    this.Dispose();
                    emple.Show();
                }else
                {
                    MessageBox.Show("Ya existe un empleado con ese DNI");
                }
            }
            else
            {
                MessageBox.Show("Error, revise los datos.");
            }
                
        }
    }
}
