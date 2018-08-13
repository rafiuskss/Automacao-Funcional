using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional
{
    [Binding]
    public class DataTableSteps
    {
        private DataTablePageActions pageActions = new DataTablePageActions();

        [When(@"click to change the page")]
        public void WhenClickToChangeThePage()
        {
            pageActions.ClickNextPage();
        }
        
        [Then(@"page changed successfully")]
        public void ThenPageChangedSuccessfully()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidNextPage();
        }
    }
}
