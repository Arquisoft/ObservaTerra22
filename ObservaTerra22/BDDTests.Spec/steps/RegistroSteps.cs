using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class RegistroSteps
    {
        [Given(@"un usuario no logueado en el sistema")]
public void DadoUnUsuarioNoLogueadoEnElSistema()
{
    ScenarioContext.Current.Pending();
}

        [When(@"el usuario lanza una petición de registro al sistema")]
public void CuandoElUsuarioLanzaUnaPeticionDeRegistroAlSistema()
{
    ScenarioContext.Current.Pending();
}

        [When(@"completa el formulario de registro")]
public void CuandoCompletaElFormularioDeRegistro()
{
    ScenarioContext.Current.Pending();
}

        [When(@"el identificador de dicho usuario ya está siendo usado en el sistema")]
public void CuandoElIdentificadorDeDichoUsuarioYaEstaSiendoUsadoEnElSistema()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"se crea una cuenta a dicho usuario, pero dicha cuenta no estará habilitada hasta que el administrador cambie su estado")]
public void EntoncesSeCreaUnaCuentaADichoUsuarioPeroDichaCuentaNoEstaraHabilitadaHastaQueElAdministradorCambieSuEstado()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"se avisará al usuario para que elija otro identificador y no se creará la cuenta")]
public void EntoncesSeAvisaraAlUsuarioParaQueElijaOtroIdentificadorYNoSeCrearaLaCuenta()
{
    ScenarioContext.Current.Pending();
}
    }
}
