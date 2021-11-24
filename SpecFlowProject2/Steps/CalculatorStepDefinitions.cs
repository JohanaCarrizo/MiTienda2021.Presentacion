using LaTienda2021is.Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {         

       private readonly ScenarioContext _scenarioContext;
        public bool precioMenor;
        public bool CondicionTributariaIgual;
        public bool EsAnonimo;



       public CalculatorStepDefinitions(ScenarioContext scenarioContext)
       {
           _scenarioContext = scenarioContext;
       }

       [Given("Dado que el Precio total de venta (.*)")]
       public void GivenDadoQueElPrecioTotalDeVenta(int number)
       {
           
            precioMenor = number < 10000 ? true : false; 

           
       }

       [Given("Condición tributaria (.*)")]
       public void GivenCondicionTributaria(string ct)
       {
           CondicionTributariaIgual = ct == "Consumidor Final" ? true : false;

           
        }
        
       [When("Se desea finalizar la venta")]
       public void WhenSeDeseaFinalizarLaVenta()
       {
            if (precioMenor == true && CondicionTributariaIgual == true) EsAnonimo = true;

          
       }

       [Then("Se obtiene el cliente (.*)")]
       public void ThenSeObtieneElCliente(string cuit)
       {
            var clienteEncontrado = RepositorioCliente.ObtenerCliente(cuit);
            Assert.AreEqual(clienteEncontrado.RazonSocial, "Consumidor Final");

           
       }
    }
}
