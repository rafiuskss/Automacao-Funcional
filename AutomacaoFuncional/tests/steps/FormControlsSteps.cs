using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


        [When(@"Clicked on the calendar")]
        public void WhenClickedOnTheCalendar()
        {
            pageActions.OpenCalendar();
        }


        [Then(@"Calendar opened successfully")]
        public void ThenCalendarOpenedSuccessfully()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidCalendar();
        }


        [When(@"I entered a valid email ""(.*)""")]
        public void WhenIEnteredAValidEmail(string arg)
        {
            pageActions.InsertEmail(arg);
        }


        [Then(@"Validated email")]
        public void ThenValidatedEmail()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidInsertEmail();
        }


        [When(@"I select the option ""(.*)""")]
        public void WhenISelectTheOption(string arg)
        {
            pageActions.SelectIten(arg);
        }


        [Then(@"Valid the option selected ""(.*)""")]
        public void ThenValidTheOptionSelected(string arg)
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidSelect(arg);
        }


    }
}
