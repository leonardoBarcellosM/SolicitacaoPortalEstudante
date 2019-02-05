﻿using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    [Binding]
    public class AtualizarStatusSgCred
    {
        UpdateStatusDB pageAction = new UpdateStatusDB();

        [Given(@"Realizo update de status")]
        public void GivenRealizoUpdateDeStatus()
        {

            pageAction.Consulta();
        }

        [Then(@"Update realizado com sucesso")]
        public void ThenUpdateRealizadoComSucesso()
        {
            bool result = pageAction.ValidarUpdate();
            //result = false;

                Assert.That(result, Is.True, "Erro ao acessar o endereço solicitado!");
        }
    }
}
