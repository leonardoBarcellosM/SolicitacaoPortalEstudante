using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    class AccessElementsMap
    {
        [FindsBy(How = How.XPath, Using = "//div//a[@class='logo']")]
        [CacheLookup]
        public IWebElement Logo { get; set; }
    }
}
