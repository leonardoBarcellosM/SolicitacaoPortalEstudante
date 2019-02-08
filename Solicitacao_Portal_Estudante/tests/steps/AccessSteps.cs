using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    [Binding]
    public class AccessSteps
    {
        private AcessPageActions pageAction = new AcessPageActions();
        //private FilaDeTrabalhoActions Fila = new FilaDeTrabalhoActions();

        [Given(@"Acessar o endereco ""(.*)""")]
        public void GivenAcessarOEndereco(string url)
        {
            var result = pageAction.AccessPage(url);

                Assert.That(result, Is.True, "Erro ao acessar a URL!");
        }
        
        [Then(@"Validar o carregamento")]
        public void ThenValidarOCarregamentoComSucesso()
        {
            var result = pageAction.ValidAccessPage();
            
                Assert.That(result, Is.True, "Erro ao acessar o endereço solicitado!");
        }
       
    }
}
