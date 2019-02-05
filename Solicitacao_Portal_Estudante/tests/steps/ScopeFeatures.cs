using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Solicitacao_Portal_Estudante.tests.steps
{
    [Binding]
    class ScopeFeatures
    {
        private ClassUtilities util = new ClassUtilities();


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            string dataHora = ClassUtilities.PegarDataHora();

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureInfo featureInfo)
        {
            string typeBrowser = featureInfo.Title.Contains("-") ? featureInfo.Title.Split('-')[0] : null;
            ClassDriver.GetInstance().StartDriver(typeBrowser);
        }

        [BeforeScenario]
        public static void BeforeScenario(FeatureInfo featureInfo)
        {
       
        }

        [BeforeStep]
        public static void BeforeStep()
        {

        }


        [AfterStep]
        public static void AfterStep()
        {
            
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            ClassDriver.GetInstance().QuitDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            
        }           
    }
}
