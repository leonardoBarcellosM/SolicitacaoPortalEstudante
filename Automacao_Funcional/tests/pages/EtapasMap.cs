﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Automacao_Funcional.tests.steps
{
    class EtapasMap
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='panel main-panel']//div[@class='row'][1]//div[1]//a")]
        [CacheLookup]
        public IWebElement OptionSolicitacao { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-laranja btn-line-wrap btn-destaque btn-block']")]
        [CacheLookup]
        public IWebElement BtnQueroSolicitarCrd { get; set; }
    }


}