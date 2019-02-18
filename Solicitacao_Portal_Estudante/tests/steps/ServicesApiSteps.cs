using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    [Binding]
    public class ServicesApiSteps
    {
        ServicesApi PageActions = new ServicesApi();

        [Given(@"Request")]
        public void GivenRequest()
        {
           bool result = PageActions.ConsultarServicoCarregarSolicitacao();
           Assert.That(result, Is.True, "Erro request!");
        }
    }
}
