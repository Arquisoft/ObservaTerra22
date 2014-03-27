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
    [TechTalk.SpecRun.FeatureAttribute("Acceso al sistema", SourceFile="features\\Acceso.feature", SourceLine=1)]
    public partial class AccesoAlSistemaFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Acceso.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("es-ES"), "Acceso al sistema", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Un usuario registrado se loguea", SourceLine=3)]
        public virtual void UnUsuarioRegistradoSeLoguea()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Un usuario registrado se loguea", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("un usario registrado en el sistema y con su cuenta habilitada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 6
 testRunner.When("dicho usuario se loguea en el sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 7
 testRunner.Then("el sistema le asigna un token que representa el tipo de usuario que es, y le perm" +
                    "ite el acceso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Un usuario no registrado se loguea", SourceLine=8)]
        public virtual void UnUsuarioNoRegistradoSeLoguea()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Un usuario no registrado se loguea", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.Given("un usuario no registrado en el sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 11
 testRunner.When("dicho usuario se loguea en el sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 12
 testRunner.Then("el sistema rechaza su petición de acceso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Un usuario registrado pero sin habilitar se loguea", SourceLine=13)]
        public virtual void UnUsuarioRegistradoPeroSinHabilitarSeLoguea()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Un usuario registrado pero sin habilitar se loguea", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("un usuario registrado en el sistema, pero cuya cuenta no ha sido habilitada todav" +
                    "ía", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 16
 testRunner.When("dicho usuario se loguea en el sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 17
 testRunner.Then("el sistema rechaza su petición", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Un usuario accede al sistema sin loguearse", SourceLine=18)]
        public virtual void UnUsuarioAccedeAlSistemaSinLoguearse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Un usuario accede al sistema sin loguearse", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("un usuario no logueado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 21
 testRunner.When("el usuario accede al sistema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 22
 testRunner.Then("el sistema le asigna un token por defecto que lo identifica como un usuario no re" +
                    "gistrado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
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
