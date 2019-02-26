﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Automacao_Funcional.tests.steps
{
    class IniciarFluxoComeceAgoraActions : IniciarFluxoComeceAgoraMap
    {
        private MassaDeDados massa = new MassaDeDados();
        private ClassUtilities util = new ClassUtilities();
        private AprovacaoIesActions cpf = new AprovacaoIesActions();

        public IniciarFluxoComeceAgoraActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool PreencherOsDados()
        {
            bool _result = false;
            string mail = util.GerarNumRandom();
            mail = "teste_" + mail + massa.email;
            string cpf = util.GerarCpf();

            ConsultaDB.Cpf(cpf);

            cpf = util.MascaraCpf(cpf);

            try
            {
                //MassaDeDados.BKey = "SOLICITACAO " + cpf;
               // UpdateStatusDB.Cpf(cpf);

                //string dt = utils.ClassUtilities.PegarDataHora();
                //string arquivo = @"C:\Users\leonardo.barcellos\Desktop\Fundacred\reg\" + dt + ".txt";
                
                //StreamWriter Doc = new StreamWriter(arquivo);
                //string line = String.Empty;

        
                //Doc.WriteLine(DateTime.Now);
                //Doc.WriteLine("CPF: " + cpf);
                //Doc.WriteLine("\r\n\r\n");
                //Doc.Close();

                util.WaitForElementVisible(BtnIniciar, 60);

                if (BtnIniciar.Displayed) {

                    BtnIniciar.Click();
                    Thread.Sleep(1000);

                    campoNome.Click();
                    Thread.Sleep(500);
                    campoNome.SendKeys(massa.nome + " " + massa.sobrenome);
                    Thread.Sleep(500);
                    LabelCpf.Click();
                    Thread.Sleep(800);
                    InputCpf.SendKeys(cpf);
                    Thread.Sleep(500);
                    campoTelefone.Click();
                    Thread.Sleep(500);
                    campoTelefone.SendKeys(massa.telefone);
                    Thread.Sleep(500);
                    campoEmail.Click();
                    Thread.Sleep(500);
                    campoEmail.SendKeys(mail);
                    Thread.Sleep(500);
                    campoEmailConf.Click();
                    Thread.Sleep(500);
                    campoEmailConf.SendKeys(mail);
                    Thread.Sleep(500);
                    campoSenha.Click();
                    Thread.Sleep(500);
                    campoSenha.SendKeys(massa.senha);
                    Thread.Sleep(500);
                    senhaConf.Click();
                    Thread.Sleep(500);
                    senhaConf.SendKeys(massa.senha);
                    Thread.Sleep(500);

                    _result = true;
                }
                else
                {
                    //Error
                }
            }
            catch
            {
                //Error
            }

            return _result;
        }

        public bool ClicarComeceAgora()
        {
            bool _result = false;

            try
            {
                Thread.Sleep(1000);
                if (btnCadastro.Displayed)
                {
                    btnCadastro.Submit();
                    _result = true;
                }
                else
                {
                    util.ScreenshotPrepare();
                }
            }
            catch
            {
                util.ScreenshotPrepare();
            }

            return _result;
        }


        public bool FluxoIniciadoComSucesso()
        {
            bool _result = false;
          
            try
            {
                Thread.Sleep(2500);
                IWebElement BemVindo = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//H1[@class='hidden-sm hidden-xs'][text()='Portal do Estudante']/self::H1"));

                WebDriverWait wait = new WebDriverWait(ClassDriver.GetInstance().Driver, TimeSpan.FromSeconds(45));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//H1[@class='hidden-sm hidden-xs'][text()='Portal do Estudante']/self::H1")));


                if (BemVindo.Displayed)
                {
                    _result = true;
                    Thread.Sleep(1500);
                }
                else
                {
                  
                }
            }
            catch
            {
                
            }
            return _result;
 
        }

        //public bool ValidarCadastroDB()
        //{
        //    bool _result = false;
        //    try
        //    {
        //        string valor = db.NovoCadastro();

        //        if (valor == "1")
        //        {
        //            _result = true;
        //        }
              
        //    }
        //    catch
        //    {

        //    }
        //    return _result;
        //}
    }
}
