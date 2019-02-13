﻿using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    [Binding]
    public class ValidarFunilIesSteps
    {
        ValidarFunilIesActions pageAction = new ValidarFunilIesActions();

        [Given(@"Consulto os dados no banco ""(.*)""")]
        public void GivenConsultoOsDadosNoBanco(string arg)
        {
            bool result = pageAction.ConsultarDB(arg);
            
                Assert.That(result, Is.True, "Erro ao consultar o banco de dados!"); 
        }

        [Then(@"Consulto os dados do funil")]
        public void ThenConsultoOsDadosDoFunil()
        {
            bool result = pageAction.ConsultarDadosFunil();

            
                Assert.That(result, Is.True, "Erro ao capturar os dados do funil!");
        }

        [Then(@"Valido solicitacoes iniciadas")]
        public void ThenValidoSolicitacoesIniciadas()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarIniciados(ref result, ref valores);

            Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido pendente analise fundacred")]
        public void WhenValidoPendenteFundacred()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarPendenteFundacred(ref result, ref valores);

            Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido Pendente analise ies")]
        public void WhenValidoPendenteAnaliseIes()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarPendenteIes(ref result, ref valores);

            Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido aprovados")]
        public void WhenValidoAprovados()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarAprovados(ref result, ref valores);

            Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido reprovados fundacred")]
        public void WhenValidoReprovados()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarReprovadosFundacred(ref result, ref valores);

            Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }

        [When(@"Valido reprovados ies")]
        public void WhenValidoReprovadosIes()
        {
            bool result = false;
            string valores = "";

            pageAction.ValidarReprovadosIes(ref result, ref valores);

            Assert.That(result, Is.True, "Dados não conferem: " + valores);
        }
        
    }
}
