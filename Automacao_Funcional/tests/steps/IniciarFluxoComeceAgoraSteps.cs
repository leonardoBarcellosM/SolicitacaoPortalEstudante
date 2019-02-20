﻿using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{

    [Binding]
    public class IniciarFluxoComeceAgoraSteps
    {
        private IniciarFluxoComeceAgoraActions pageAction = new IniciarFluxoComeceAgoraActions();

        [Given(@"Preencher os dados")]
        public void GivenPreencherOsDados()
        {
            bool result = pageAction.PreencherOsDados();

                Assert.That(result, Is.True, "Erro ao preencher os dados!");
        }

        [When(@"Clicar em Comece agora sem compromisso")]
        public void WhenClicarEmComeceAgoraSemCompromisso()
        {
            bool result = pageAction.ClicarComeceAgora();

                Assert.That(result, Is.True, "Erro ao clicar em comece agora!");
        }

        [Then(@"Validar se o fluxo e iniciado")]
        public void ThenValidarSeOFluxoEIniciado()
        {
            var result = pageAction.FluxoIniciadoComSucesso();

                Assert.That(result, Is.True, "Erro ao iniciar o fluxo Comece Agora Sem Compromisso!");
        }


        //[Then(@"Validar cadastro")]
        //public void ThenValidarCadastro()
        //{
        //    var result = pageAction.ValidarCadastroDB();

        //        Assert.That(result, Is.True, "Erro ao cadastrar os dados no DB!");
        //}


    }
}