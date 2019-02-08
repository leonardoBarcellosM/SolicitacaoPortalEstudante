using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    [Binding]
    public class ValidarTelaPesquisaSteps
    {
        ValidarTelaPesquisaAction pageAction = new ValidarTelaPesquisaAction();

        [When(@"Valido o direcionamento para a tela de pesquisa ""(.*)""")]
        public void WhenValidoODirecionamentoParaATelaDePesquisa(string arg)
        {
            bool result = pageAction.ValidarTelaDePesquisa(arg);

            Assert.That(result, Is.True, "Erro - Valido o direcionamento para a tela de pesquisa!");
        }

        //[When(@"Verifico o filtro selecionado ""(.*)""")]
        //public void WhenVerificoOFiltroSelecionado(string arg)
        //{
        //    bool result = pageAction.ValidarFiltroSelecionado(arg);

        //    Assert.That(result, Is.True, "Erro - Valido o direcionamento para a tela de pesquisa!");
        //}

        [Then(@"Verifico o total de ""(.*)""")]
        public void ThenVerificoOTotalDeSolicitacoesListadas(string arg)
        {
            bool result = false;
            string vlr = null;
            switch (arg)
            {
                case "Solicitações Iniciadas":
                    (result, vlr) = pageAction.ValidarTotalDeSolicitacoes(0);
                    break;
                case "Reprovados Fundacred":
                    (result, vlr) = pageAction.ValidarTotalDeSolicitacoes(1);
                    break;
                case "Pendente Análise Fundacred":
                    (result, vlr) = pageAction.ValidarTotalDeSolicitacoes(2);
                    break;
                case "Pendente Análise Ies":
                    (result, vlr) = pageAction.ValidarTotalDeSolicitacoesPendentesIes();
                    break;
                case "Reprovadas IES":
                    (result, vlr) = pageAction.ValidarTotalDeSolicitacoes(4);
                    break;
                case "Aprovadas":
                    (result, vlr) = pageAction.ValidarTotalDeSolicitacoes(5);
                    break;
                    
            }

            Assert.That(result, Is.True, "Erro - Verifico o total de solicitacoes listadas! |  " + vlr);
        }

        [Given(@"Consulto a lista de etapas")]
        public void GivenConsultoAListaDeEtapas()
        {
            bool  result = pageAction.ValidarEtapasFiltro();

            Assert.That(result, Is.True, "Erro - Consulto a lista de etapas!");
        }

        [Then(@"Verifico as informacoes basicas de listagem de solicitacao")]
        public void ThenConsultoAListaDeEtapas()
        {
            bool result = pageAction.ValidarInformacoesApresentadas();

            Assert.That(result, Is.True, "Erro - Verifico as informacoes basicas de listagem de solicitacao!");
        }

    }
}
