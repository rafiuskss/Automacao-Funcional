using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    public class MenusSteps
    {
        private MenuPageActions pageActions = new MenuPageActions();
        [Given(@"Access the menu ""(.*)""")]
        public void GivenAccessTheMenu(string arg)
        {
            pageActions.AccessMenu(arg);
        }
        

        [Given(@"Access the submenu ""(.*)""")]
        public void GivenAccessTheSubmenu(string arg)
        {
            pageActions.AccessSubMenu(arg);
        }

    }
}
