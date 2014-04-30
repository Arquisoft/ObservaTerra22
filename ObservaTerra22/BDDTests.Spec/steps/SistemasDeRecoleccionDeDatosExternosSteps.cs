using System;
using TechTalk.SpecFlow;

namespace BDDTests.Spec.steps
{
    [Binding]
    public class SistemasDeRecoleccionDeDatosExternosSteps
    {
        [Given(@"un nuevo sistema de recolección es agregado, no importa el lenguage de programación en el que esté programado")]
public void DadoUnNuevoSistemaDeRecoleccionEsAgregadoNoImportaElLenguageDeProgramacionEnElQueEsteProgramado()
{
    ScenarioContext.Current.Pending();
}

        [When(@"se lanzan los sistemas de recolección de datos externos")]
public void CuandoSeLanzanLosSistemasDeRecoleccionDeDatosExternos()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"se lanzará también este nuevo sistema y se procesarán sus resultados")]
public void EntoncesSeLanzaraTambienEsteNuevoSistemaYSeProcesaranSusResultados()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"el sistema principal no detendrá su ejecución en todo este proceso")]
public void EntoncesElSistemaPrincipalNoDetendraSuEjecucionEnTodoEsteProceso()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"todas las fuentes a las que el sistema está suscrito serán analizadas, y sus resultados procesados")]
public void EntoncesTodasLasFuentesALasQueElSistemaEstaSuscritoSeranAnalizadasYSusResultadosProcesados()
{
    ScenarioContext.Current.Pending();
}
    }
}
