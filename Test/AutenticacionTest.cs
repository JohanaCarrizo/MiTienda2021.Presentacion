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
            //Configuraci�n
            Empleado empleado = new Empleado(42171, "Pablo Dibi", "ISI2021", Rol.Vendedor);
            RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();

            //Ejecuci�n
            var empleadoEncontrado = repositorioEmpleado.buscarEmpleado(empleado.Legajo);

            //Comprobaci�n
            Assert.AreNotEqual(null , empleadoEncontrado);

            //Limpieza

        }


        [TestMethod]
        public void VerificacionDeContrase�a()
        {
            //Configuraci�n
            Empleado empleado = new Empleado(42171, "Pablo Dibi", "ISI2021", Rol.Vendedor);

            //Ejecuci�n
            var resultado = empleado.VerificarContrase�a(empleado.Contrase�a);

            //Comprobaci�n
            Assert.AreEqual(true, resultado);

            //Limpieza

        }

        [TestMethod]
        public void SeCalculaCorrectamenteElPrecioDeVentaDeUnProducto()
        {
            //Configuraci�n
            Producto producto = new Producto(99, 1, new Talle(99, TipoTalle.Usa, "5"), Rubro.CalzadosDeportivos, "Adidas", "T90", 3500, 0.7, 21);

            //Ejecuci�n
            var resultado = producto.PrecioDeVenta;

            //Comprobaci�n
            Assert.AreEqual(7199.5, resultado);

            //Limpieza

        }

        [TestMethod]
        public void AlGuardarUnProductoElRepositorioAumentadeTama�oEnUno()
        {
            //Configuraci�n
            Producto producto = new Producto(99, 1, new Talle(99, TipoTalle.Usa, "5"), Rubro.CalzadosDeportivos, "Adidas", "T90", 3500, 0.7, 21);
            RepositorioProducto repositorioProducto = new RepositorioProducto();

            //Ejecuci�n
            repositorioProducto.AgregarProducto(producto);
            var resultado = RepositorioProducto.productos.Count;

            //Comprobaci�n
            Assert.AreEqual(2, resultado);

            //Limpieza

        }

        [TestMethod]
        public void GestorRealizarVentaAutocalculaElIDDeVenta()
        {
            //Configuraci�n
            GestorRealizarVenta gestorRealizarVenta = new GestorRealizarVenta();
            var respuestaEsperada = RepositorioVenta.Ventas.Count + 1;

            //Ejecuci�n
            var resultado = gestorRealizarVenta.CrearVenta();


            //Comprobaci�n
            Assert.AreEqual(respuestaEsperada, resultado);
        }
    }
}
