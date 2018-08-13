using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class MenusSteps
    {
        [Given(@"Access the menu ""(.*)""")]
        public void GivenAccessTheMenu(string arg)
        {
            ClassInfo.GetInstance().ResultScenario = new MenuPageActions().AccessMenu(arg);
        }
       
    }
}
