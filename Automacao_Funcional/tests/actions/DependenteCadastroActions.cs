using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Automacao_Funcional.tests.steps;

namespace Automacao_Funcional.tests.actions
{
    class DependenteCadastroActions : DependenteCadastroMap
    {
        private ClassUtilities util = new ClassUtilities();
        private MassaDeDados massa = new MassaDeDados();

        public DependenteCadastroActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

    }
}
