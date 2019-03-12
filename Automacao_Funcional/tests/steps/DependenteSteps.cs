using Automacao_Funcional.tests.actions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class DependenteSteps
    {
        DependenteCadastroActions pageAction = new DependenteCadastroActions();

        [Given(@"Preencho os dados do dependente")]
        public void GivenPreenchoOsDadosDoDependente()
        {
            //bool result = pageAction.PreencherDadosDependente();

            //Assert.That(result, Is.True, "Erro ao inserir os dados pessoais do estudante!");
        }

        [When(@"Clico em enviar")]
        public void WhenClicoEmEnviar()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Os dados devem ser salvos com sucesso na tabela dependentes")]
        public void ThenOsDadosDevemSerSalvosComSucessoNaTabelaDependentes()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
