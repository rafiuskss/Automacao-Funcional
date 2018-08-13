using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional
{
    [Binding]
    public class ButtonsIndicatorsSteps
    {
        private ButtonsIndicatorsPageActions pageActions = new ButtonsIndicatorsPageActions();

        [When(@"I clicked the buttonToggle")]
        public void WhenIClickedTheButtonToggle()
        {
            pageActions.ClickButtonToggle();
        }
        
        [Then(@"ButtonToggle selected")]
        public void ThenButtonToggleSelected()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidButtonToggle();
        }

        [When(@"Insert new chips ""(.*)""")]
        public void WhenInsertNewChips(string arg)
        {
            pageActions.InsertNewChips(arg);
        }

        [Then(@"Chips inserted successfully the text ""(.*)""")]
        public void ThenChipsInsertedSuccessfullyTheText(string arg)
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidNewChips(arg);
        }

    }
}
