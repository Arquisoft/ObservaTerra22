using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class GestionDeObservacionesSteps
    {
        [Given(@"una lista de observaciones sobre un indicador dado:")]
public void DadoUnaListaDeObservacionesSobreUnIndicadorDado(Table table)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"una lista vacía de observaciones que el sistema posee sobre un área o indicador determinado")]
public void DadoUnaListaVaciaDeObservacionesQueElSistemaPoseeSobreUnAreaOIndicadorDeterminado()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"una lista de indicadores sobre un aspecto determinado:")]
public void DadoUnaListaDeIndicadoresSobreUnAspectoDeterminado(Table table)
{
    ScenarioContext.Current.Pending();
}

        [Given(@"se añade una nueva observación sobre ese aspecto en Chile")]
public void DadoSeAnadeUnaNuevaObservacionSobreEseAspectoEnChile()
{
    ScenarioContext.Current.Pending();
}

        [When(@"se calcula la nota media de dicho indicador")]
public void CuandoSeCalculaLaNotaMediaDeDichoIndicador()
{
    ScenarioContext.Current.Pending();
}

        [When(@"se realiza una petición de dicha lista")]
public void CuandoSeRealizaUnaPeticionDeDichaLista()
{
    ScenarioContext.Current.Pending();
}

        [When(@"se reciba una petición sobre dicho aspecto en Chile")]
public void CuandoSeRecibaUnaPeticionSobreDichoAspectoEnChile()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"el resultado debe ser el valor (.*)")]
public void EntoncesElResultadoDebeSerElValor(int p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"el sistema informará al usuario que no se poseen datos sobre las observaciones pedidas")]
public void EntoncesElSistemaInformaraAlUsuarioQueNoSePoseenDatosSobreLasObservacionesPedidas()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"se devolverá un resultado formado por las (.*) observaciones que contienen dicho aspecto en Chile")]
public void EntoncesSeDevolveraUnResultadoFormadoPorLasObservacionesQueContienenDichoAspectoEnChile(int p0)
{
    ScenarioContext.Current.Pending();
}
    }
}
