using LaTienda2021is.Aplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda2021.Presentacion
{
    public class ControladorAutenticarEmpleado
    {
        GestorIniciarSesion GestorIniciarSesion = new GestorIniciarSesion();

        public bool AutenticarEmpleado(string legajo, string contraseña)
        {
            return GestorIniciarSesion.AutenticarEmpleado(legajo, contraseña);
        }
    }
}
