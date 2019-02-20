using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Automacao_Funcional.tests.steps
{
    class LoginActions :  LoginMap
    {
        private ClassUtilities util = new ClassUtilities();

        public LoginActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public bool AcessarTelaLogin()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnEntrar, 15);
                if (BtnEntrar.Displayed)
                {
                    BtnEntrar.Click();
                    _result = true;
                }

            }
            catch
            {

            }
            return _result;
        }

        public bool PreencherCampos(Table table)
        {
            bool _result = false;
            var credentials = table.CreateInstance<ClassUtilities.Credentials>();

            try
            {
                util.WaitForElementVisible(InputCpf, 45);
                if (InputCpf.Displayed)
                {
                    InputCpf.Click();
                    Thread.Sleep(300);
                    InputCpf.SendKeys(credentials.Cpf);
                    Thread.Sleep(300);
                    InputSenha.Click();
                    Thread.Sleep(300);
                    InputSenha.SendKeys(credentials.Senha);
                    Thread.Sleep(300);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool Submit()
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(BtnSubmit, 45);
                if (BtnSubmit.Displayed)
                {
                    BtnSubmit.Click();
                    //Thread.Sleep(3000);

                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarLogin()
        {
            bool _result = false;
            Thread.Sleep(3000);
            try
            {
                IWebElement BemVindo = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='panel main-panel']"));
                util.WaitForElementVisible(BemVindo, 45);
                if (BemVindo.Displayed)
                {
                    _result = true;
                    Thread.Sleep(3000);
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool PreencherUsuario(string user)
        {
            bool _result = false;

            try
            {
                util.WaitForElementVisible(InputCpf, 45);
                if (InputCpf.Displayed)
                {
                    InputCpf.Click();
                    Thread.Sleep(300);
                    InputCpf.SendKeys(user);
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

        public bool ValidarSenhaIncorreta()
        {
            bool _result = false;

            try
            {
                IWebElement MsgErro = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[5]"));
                util.WaitForElementVisible(MsgErro, 45);
                if (MsgErro.Displayed)
                {
                    _result = true;
                }
            }
            catch
            {

            }
            return _result;
        }

       
            public bool PreencherUserPassword()
            {
                bool _result = false;
                util.WaitForElementVisible(CampoUsername, 45);

                try
                {
                    if (CampoUsername.Displayed)
                    {
                        CampoUsername.Clear();
                        CampoUsername.SendKeys("demo");
                        CampoPassword.Clear();
                        CampoPassword.SendKeys("demo");

                        _result = true;
                    }
                }
                catch
                {
                }
                return _result;
            }

            public bool ClicarSignIn()
            {
                bool _result = false;

                try
                {
                    if (BtnSignIn.Displayed)
                    {
                        BtnSignIn.Click();

                        _result = true;
                    }
                }
                catch
                {
                }
                return _result;
            }

            public bool ValidarLoginCamunda()
            {
                bool _result = false;
                Thread.Sleep(2000);

                IWebElement Validar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("/html/body/div[1]/nav/ul/li[2]/a"));

                try
                {
                    if (Validar.Displayed)
                    {
                        _result = true;
                    }
                }
                catch
                {
                }
                return _result;
            }

            public bool ValidarAcessoIes()
            {
                bool _result = false;
                try
                {
                    Thread.Sleep(10000);
                    IWebElement formLogin = ClassDriver.GetInstance().Driver.FindElement(By.Id("formLogin"));
                    util.WaitForElementVisible(formLogin, 45);
                    if (formLogin.Displayed)
                    {
                        _result = true;
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
        }
}
