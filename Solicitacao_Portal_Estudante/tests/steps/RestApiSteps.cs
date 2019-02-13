using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    [Binding]
    public class RestApiSteps
    {
        private RestApi pageAction = new RestApi();

        [Given(@"Consultar retorno do servico de carregar solicitação")]
        public void GivenConsultarRetornoDoServicoDeCarregarSolicitação()
        {
            bool result = pageAction.ConsultarToken();

            Assert.That(result, Is.True, "Consultar retorno do servico de carregar solicitação!");
        }

        
    }
}
