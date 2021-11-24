using LaTienda2021is.Aplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTienda2021.Presentacion
{
    public partial class Form1 : Form
    {
        ControladorAutenticarEmpleado controladorAutenticarEmpleado = new ControladorAutenticarEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(controladorAutenticarEmpleado.AutenticarEmpleado(txtLegajo.Text , txtContraseña.Text) == true)
            {
                MessageBox.Show("Sesion Iniciada Correctamente");
                MenuVendedor menuVendedor = new MenuVendedor();
                menuVendedor.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
