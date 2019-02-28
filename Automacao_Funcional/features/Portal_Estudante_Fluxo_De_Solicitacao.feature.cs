﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Automacao_Funcional.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("H-Portal_Estudante_Fluxo_De_Solicitacao")]
    public partial class H_Portal_Estudante_Fluxo_De_SolicitacaoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Portal_Estudante_Fluxo_De_Solicitacao.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "H-Portal_Estudante_Fluxo_De_Solicitacao", "\tUse before title fiture separed with \"-\":\r\n\t \'C\' for Chrome;\r\n\t \'I\' for Internet" +
                    " Explorer;\r\n\t \'F\' for FireFox Mozilla;\r\n\t \'E\' for Edge;\r\n\t \'H\' for Headless Chro" +
                    "me;\r\n\t Default: Chrome", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Acessar o endereco")]
        [NUnit.Framework.CategoryAttribute("01_AcessarPagina")]
        public virtual void _01AcessarOEndereco()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Acessar o endereco", null, new string[] {
                        "01_AcessarPagina"});
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
testRunner.Given("Acessar o endereco \"http://homologacao.fundacred.org.br/estudante-web/#/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
testRunner.Then("Validar o carregamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 Iniciar Fluxo Comece Agora")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _02IniciarFluxoComeceAgora()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Iniciar Fluxo Comece Agora", null, new string[] {
                        "02_1Etapa"});
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 17
testRunner.Given("Preencher os dados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
testRunner.When("Clicar em Comece agora sem compromisso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
testRunner.Then("Validar se o fluxo e iniciado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 Iniciar Solicitacao")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _03IniciarSolicitacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Iniciar Solicitacao", null, new string[] {
                        "02_1Etapa"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
testRunner.Given("Acessar a opcao solicitacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
testRunner.When("Clicar em quero solicitar o credito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
testRunner.Then("Validar o direcionamento com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04 Selecionar Instituicao")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _04SelecionarInstituicao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04 Selecionar Instituicao", null, new string[] {
                        "02_1Etapa"});
#line 28
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 29
testRunner.Given("Selecionar instituicao \"USF - UNIVERSIDADE SAO FRANCISCO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
testRunner.When("Selecionar curso \"ADMINISTRAÇÃO-NOTURNO-BRAGANÇA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
testRunner.And("Clicar no botao aceito os termos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
testRunner.Then("Validar solicitacao enviada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05 Validar DB solicitação iniciada")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _05ValidarDBSolicitacaoIniciada()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05 Validar DB solicitação iniciada", null, new string[] {
                        "02_1Etapa"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
testRunner.Then("Validar status de solicitacao no db \"Solicitacao\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06 Preencher Dados Do Estudante")]
        [NUnit.Framework.CategoryAttribute("02_2Etapa")]
        public virtual void _06PreencherDadosDoEstudante()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06 Preencher Dados Do Estudante", null, new string[] {
                        "02_2Etapa"});
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 40
testRunner.Given("Clicar no botao enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
testRunner.Then("Validar direcionamento para etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("07 Validar DB atualização do estudante")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _07ValidarDBAtualizacaoDoEstudante()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07 Validar DB atualização do estudante", null, new string[] {
                        "02_1Etapa"});
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 45
testRunner.Then("Validar status de solicitacao no db \"Estudante\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("08 Preencher Dados Do Fiador")]
        [NUnit.Framework.CategoryAttribute("03_3Etapa")]
        public virtual void _08PreencherDadosDoFiador()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("08 Preencher Dados Do Fiador", null, new string[] {
                        "03_3Etapa"});
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 49
testRunner.Given("Inserir nome e cpf \" Leonardo Barcellos Teste \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
testRunner.When("Inserir data de nasc e renda \"5.000,00-06/08/2000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.And("Clicar no botao enviar etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
testRunner.Then("Validar direcionamento para etapa 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("09 Validar DB atualização do fiador")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _09ValidarDBAtualizacaoDoFiador()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("09 Validar DB atualização do fiador", null, new string[] {
                        "02_1Etapa"});
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 56
testRunner.Then("Validar status de solicitacao no db \"Fiador\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
