﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34011
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDDTests.Spec.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Fuentes de datos externas", SourceFile="features\\FuentesDatosExternas.feature", SourceLine=1)]
    public partial class FuentesDeDatosExternasFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FuentesDatosExternas.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("es-ES"), "Fuentes de datos externas", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Obtener publicaciones de fuentes de información externa", SourceLine=3)]
        public virtual void ObtenerPublicacionesDeFuentesDeInformacionExterna()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Obtener publicaciones de fuentes de información externa", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("una lista de recursos almacenados en el sistema sobre un tema determinado en un á" +
                    "rea determinada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 6
 testRunner.And("una fuente de información a la que se ha suscrito el sistema ObservaTerra ha publ" +
                    "icado un nuevo recurso sobre dicho tema en dicha área", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line 7
 testRunner.When("el sistema lance los sistemas recolectores la siguiente vez", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 8
 testRunner.Then("la lista de recursos sobre ese tema o ese área será una unidad mayor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Agregar una nueva fuente de información externa a la lista de suscripciones", SourceLine=9)]
        public virtual void AgregarUnaNuevaFuenteDeInformacionExternaALaListaDeSuscripciones()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Agregar una nueva fuente de información externa a la lista de suscripciones", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("una lista de fuentes externas a las que el sistema está suscrito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 12
 testRunner.When("el administrador suscribe al sistema a una nueva fuente de información externa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 13
 testRunner.Then("la lista de fuentes externas a las que se ha suscrito será una unidad mayor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Recolectores de datos en una nueva fuente", SourceLine=14)]
        public virtual void RecolectoresDeDatosEnUnaNuevaFuente()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recolectores de datos en una nueva fuente", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("una lista de fuentes externas a las que el sistema está suscrito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 17
 testRunner.When("el administrador suscribe al sistema a una nueva fuente de información externa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 18
 testRunner.Then("la siguiente vez que se lancen los recolectores de datos externos, al menos uno d" +
                    "eberá analizar la nueva fuente de información y procesar sus resultados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Eliminar una fuente de información externa de la lista de suscripciones", SourceLine=19)]
        public virtual void EliminarUnaFuenteDeInformacionExternaDeLaListaDeSuscripciones()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Eliminar una fuente de información externa de la lista de suscripciones", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("una lista de fuentes externas a las que el sistema está suscrito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 22
 testRunner.When("el administrador elimina la suscripción a una de esas fuentes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 23
 testRunner.Then("la lista de fuentes externas a las que se ha suscrito será una unidad menor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Recolectores de datos tras eliminación de suscripción", SourceLine=24)]
        public virtual void RecolectoresDeDatosTrasEliminacionDeSuscripcion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recolectores de datos tras eliminación de suscripción", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("una lista de fuentes externas a la que el sistema está suscrito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 27
 testRunner.When("el administrador eliminar la suscripción a una de esas fuentes de información", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 28
 testRunner.Then("la siguiente vez que se lancen los recolectores, ninguno analizará la fuente de i" +
                    "nformación que se acaba de eliminar.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion