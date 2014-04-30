using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class AccesoAlSistemaSteps
    {
        [Given(@"un usario registrado en el sistema y con su cuenta habilitada")]
public void DadoUnUsarioRegistradoEnElSistemaYConSuCuentaHabilitada()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"un usuario no registrado en el sistema")]
public void DadoUnUsuarioNoRegistradoEnElSistema()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"un usuario registrado en el sistema, pero cuya cuenta no ha sido habilitada todavía")]
public void DadoUnUsuarioRegistradoEnElSistemaPeroCuyaCuentaNoHaSidoHabilitadaTodavia()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"un usuario no logueado")]
public void DadoUnUsuarioNoLogueado()
{
    ScenarioContext.Current.Pending();
}

        [When(@"dicho usuario se loguea en el sistema")]
public void CuandoDichoUsuarioSeLogueaEnElSistema()
{
    ScenarioContext.Current.Pending();
}

        [When(@"el usuario accede al sistema")]
public void CuandoElUsuarioAccedeAlSistema()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"el sistema le asigna un token que representa el tipo de usuario que es, y le permite el acceso")]
public void EntoncesElSistemaLeAsignaUnTokenQueRepresentaElTipoDeUsuarioQueEsYLePermiteElAcceso()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"el sistema rechaza su petición de acceso")]
public void EntoncesElSistemaRechazaSuPeticionDeAcceso()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"el sistema rechaza su petición")]
public void EntoncesElSistemaRechazaSuPeticion()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"el sistema le asigna un token por defecto que lo identifica como un usuario no registrado")]
public void EntoncesElSistemaLeAsignaUnTokenPorDefectoQueLoIdentificaComoUnUsuarioNoRegistrado()
{
    ScenarioContext.Current.Pending();
}
    }
}
