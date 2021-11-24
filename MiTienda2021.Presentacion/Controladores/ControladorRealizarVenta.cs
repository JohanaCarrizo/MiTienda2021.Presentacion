using LaTienda2021is.Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda2021.Presentacion
{
    public class ControladorRealizarVenta
    {
        GestorRealizarVenta gestorRealizarVenta = new GestorRealizarVenta();

        public int crearVenta()
        {
            return gestorRealizarVenta.CrearVenta();
        }
    }
}
