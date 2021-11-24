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
    public partial class MenuVendedor : Form
    {
        ControladorRealizarVenta controladorRealizarVenta = new ControladorRealizarVenta();

        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            controladorRealizarVenta.crearVenta();
            FormularioRealizarVenta formularioRealizarVenta = new FormularioRealizarVenta();
            formularioRealizarVenta.Show();
        }
    }
}
