using AutomacaoFuncional.tests.pages;
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
    class FormControlsSteps
    {
        private FormControlsPageActions pageActions = new FormControlsPageActions();
            
        [When(@"I typed the letter ""(.*)""")]
        public void WhenITypedTheLetter(string arg)
        {
            pageActions.AutocompleteTeste(arg);
        }

        [Then(@"""(.*)"" options were displayed")]
        public void ThenOptionsWereDisplayed(int arg)
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidAutocomplete(arg);
        }
    }
}
