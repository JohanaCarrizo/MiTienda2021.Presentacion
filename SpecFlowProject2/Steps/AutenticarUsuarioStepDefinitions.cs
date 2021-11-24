using LaTienda2021is.Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    class AutenticarUsuarioStepDefinitions
    { 
        private readonly ScenarioContext _scenarioContext;
        public string Legajo;
        public string Contraseña;
        public bool IniciaSesion;
        public RepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado();



        public AutenticarUsuarioStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("Dado un usuario con legajo (.*)")]
        public void GivenDadoUnUsuarioConLegajo(string legajo)
        {

            Legajo = legajo;
        }

        [Given("Dado un usuario con contraseña (.*)")]
        public void GivenDadoUnUsuarioConContraseña(string contraseña)
        {
            Contraseña = contraseña;
        }

        [When("Cuando el usuario ingresa al sistema")]
        public void WhenCuandoElUsuarioIngresaAlSistema()
        {
           IniciaSesion = repositorioEmpleado.buscarEmpleado(int.Parse(Legajo)) != null ? true : false;

        }

     [Then("Se realiza correctamente el inicio de sesion")]
        public void ThenSeRealizaCorrectamenteElInicioDeSesion()
        {
            Assert.AreEqual(IniciaSesion, true);
        }
    }
}
