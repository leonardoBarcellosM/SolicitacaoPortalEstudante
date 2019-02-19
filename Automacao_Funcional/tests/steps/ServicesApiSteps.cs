﻿using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Automacao_Funcional.tests.steps
{
    [Binding]
    public class ServicesApiSteps
    {
        ServicesApi PageActions = new ServicesApi();

        [Given(@"Consultar o servico de carregar a solicitacao")]
        public void GivenConsultarCarregarSolicitacao()
        {
           bool result = PageActions.ConsultarServicoCarregarSolicitacao();
           Assert.That(result, Is.True, "Service - Erro ao carregar a solicitacao!");
        }
    }
}
