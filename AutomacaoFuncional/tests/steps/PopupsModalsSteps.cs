using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class PopupsModalsSteps
    {
        private PopupsModalsPageActions pageActions = new PopupsModalsPageActions();

        [When(@"Insert the text ""(.*)""")]
        public void WhenInsertTheText(string arg)
        {
            pageActions.InsertTextPickOne(arg);
        }
        
        [When(@"Click the button Pick one")]
        public void WhenClickTheButtonPickOne()
        {
            pageActions.ClickPickOne();
        }
        
        [Then(@"Dialog opened with the text ""(.*)""")]
        public void ThenDialogOpenedWithTheText(string arg)
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidTextDialog(arg);
        }

        [When(@"Insert the message snack-bar ""(.*)""")]
        public void WhenInsertTheMessageSnack_Bar(string arg)
        {
            pageActions.InsertMessageSnackBar(arg);
        }

        [When(@"Click the button showsnack-bar")]
        public void WhenClickTheButtonShowsnack_Bar()
        {
            pageActions.ClickShowSnackBar();
        }

        [Then(@"Sneck-bar opened with the text ""(.*)""")]
        public void ThenSneck_BarOpenedWithTheText(string arg)
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidSneckBar(arg);
        }

    }
}
