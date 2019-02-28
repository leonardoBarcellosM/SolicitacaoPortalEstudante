using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class RendaMinimaSteps
    {

        ValidarRendaMinimaActions PageActions = new ValidarRendaMinimaActions();

        [When(@"Informo valor inferior ao minimo")]
        public void WhenInformoValorInferiorAoMinimo()
        {
            bool result = PageActions.InformarRendaInferior();

            Assert.That(result, Is.True, "Erro ao inserir valor no campo Renda mensal bruta");

        }

        [Then(@"Apresenta mensagem informando que o valor é insuficiente")]
        public void ThenApresentaMensagemInformandoQueOValorEInsuficiente()
        {
            bool result = PageActions.ValidarMsgRendaInvalida();

            Assert.That(result, Is.True, "Erro ao apresentar a mensagem informando que o valor é insuficiente");
        }

        [Then(@"O botao Enviar ficara desabilitado")]
        public void ThenOBotaoEnviarFicaraDesabilitado()
        {
            bool result = PageActions.ValidarBtnEnviarDisabled();

            Assert.That(result, Is.True, "Erro ao apresentar o botao enviar desabilitado");
        }

        [Then(@"A opcao quero continuar mesmo assim e apresentada")]
        public void ThenAOpcaoQueroContinuarMesmoAssimEApresentada()
        {
            bool result = PageActions.ValidarBtnContinuar();

            Assert.That(result, Is.True, "Erro ao apresentar o botão quero continuar mesmo assim");
        }

        [When(@"Informo valor superior ao minimo")]
        public void WhenInformoValorSuperiorAoMinimo()
        {
            bool result = PageActions.InformarRendaSuperior();

            Assert.That(result, Is.True, "Erro ao inserir o valor no campo Renda Mensal Bruta");
        }

        [Then(@"Apresenta mensagem informando que o valor é suficiente")]
        public void ThenApresentaMensagemInformandoQueOValorESuficiente()
        {
            bool result = PageActions.ValidarMsgRendaValida();

            Assert.That(result, Is.True, "Erro ao apresentar a mensagem informando que o valor é suficiente");
        }

        [Then(@"O botao Enviar ficara habilitado")]
        public void ThenOBotaoEnviarFicaraHabilitado()
        {
            bool result = PageActions.ValidarBtnEnviarEnabled();

            Assert.That(result, Is.True, "Erro ao apresentar o botao Enviar habilitado");
        }


    }
}
