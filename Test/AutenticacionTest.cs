using LaTienda2021is.Datos;
using LaTienda2021is.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LaTienda2021is.Aplicacion;

namespace Test
{
    [TestClass]
    public class AutenticacionTest
    {
        [TestMethod]
        public void BusquedaDeUsuario()
        {
            //Configuración
            Empleado empleado = new Empleado(42171, "Pablo Dibi", "ISI2021", Rol.Vendedor);
            RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();

            //Ejecución
            var empleadoEncontrado = repositorioEmpleado.buscarEmpleado(empleado.Legajo);

            //Comprobación
            Assert.AreNotEqual(null , empleadoEncontrado);

            //Limpieza

        }


        [TestMethod]
        public void VerificacionDeContraseña()
        {
            //Configuración
            Empleado empleado = new Empleado(42171, "Pablo Dibi", "ISI2021", Rol.Vendedor);

            //Ejecución
            var resultado = empleado.VerificarContraseña(empleado.Contraseña);

            //Comprobación
            Assert.AreEqual(true, resultado);

            //Limpieza

        }

        [TestMethod]
        public void SeCalculaCorrectamenteElPrecioDeVentaDeUnProducto()
        {
            //Configuración
            Producto producto = new Producto(99, 1, new Talle(99, TipoTalle.Usa, "5"), Rubro.CalzadosDeportivos, "Adidas", "T90", 3500, 0.7, 21);

            //Ejecución
            var resultado = producto.PrecioDeVenta;

            //Comprobación
            Assert.AreEqual(7199.5, resultado);

            //Limpieza

        }

        [TestMethod]
        public void AlGuardarUnProductoElRepositorioAumentadeTamañoEnUno()
        {
            //Configuración
            Producto producto = new Producto(99, 1, new Talle(99, TipoTalle.Usa, "5"), Rubro.CalzadosDeportivos, "Adidas", "T90", 3500, 0.7, 21);
            RepositorioProducto repositorioProducto = new RepositorioProducto();

            //Ejecución
            repositorioProducto.AgregarProducto(producto);
            var resultado = RepositorioProducto.productos.Count;

            //Comprobación
            Assert.AreEqual(2, resultado);

            //Limpieza

        }

        [TestMethod]
        public void GestorRealizarVentaAutocalculaElIDDeVenta()
        {
            //Configuración
            GestorRealizarVenta gestorRealizarVenta = new GestorRealizarVenta();
            var respuestaEsperada = RepositorioVenta.Ventas.Count + 1;

            //Ejecución
            var resultado = gestorRealizarVenta.CrearVenta();


            //Comprobación
            Assert.AreEqual(respuestaEsperada, resultado);
        }
    }
}
