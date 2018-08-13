using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class NavigationSteps
    {
        private NavigationPageActions pageActions = new NavigationPageActions();

        [When(@"I clicked the menu")]
        public void WhenIClickedTheMenu()
        {
            pageActions.ClickBasicMenu();
        }

        [Then(@"Options menus returned")]
        public void ThenOptionsMenusReturned()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidBasicMenu();
        }

        [When(@"I clicked the button enable linear mode")]
        public void WhenIClickedTheButtonEnableLinearMode()
        {
            pageActions.ClickEnableLinearMode();
        }

        [Then(@"Iten enebled")]
        public void ThenItenEnebled()
        {
            ClassInfo.GetInstance().ResultScenario = pageActions.ValidItenEnabled();
        }

    }
}
