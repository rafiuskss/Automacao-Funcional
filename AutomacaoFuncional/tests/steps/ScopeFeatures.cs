using AutomacaoFuncional.tests.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    class ScopeFeatures
    {

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureInfo featureInfo)
        {
            int typeBrowser = Int32.Parse(featureInfo.Title.Split('-')[0]);
            ClassDriver.GetInstance().StartDriver(typeBrowser);
        }

        [BeforeScenario]
        public static void BeforeScenario()
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
