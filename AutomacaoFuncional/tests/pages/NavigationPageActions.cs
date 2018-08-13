using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class NavigationPageActions : NavigationElementsMap
    {
        private ClassUtilities util = new ClassUtilities();

        public NavigationPageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void ClickBasicMenu()
        {
            try
            {
                util.WaitForElementVisible(basicMenu, 10);
                util.ScrollElementoPage(divBasicMenu);
                basicMenu.Click();
            }
            catch (Exception)
            {

            }
        }

        public void ClickEnableLinearMode()
        {
            try
            {
                util.WaitForElementVisible(buttonEnableLinearMode, 10);

                if (buttonEnableLinearMode.Enabled && buttonEnableLinearMode.Displayed)
                {
                    util.ScrollElementoPage(divButtonEnableLinearMode);
                    buttonEnableLinearMode.Click();
                }
            }
            catch (Exception)
            {

            }
        }

        public bool ValidItenEnabled()
        {
            bool _result = false;
            try
            {
                if (itenDisable.Enabled && itenDisable.Displayed)
                {
                    util.ScrollElementoPage(divButtonEnableLinearMode);
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Iten not enabled";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }

            return _result;
        }

        public bool ValidBasicMenu()
        {
            bool _result = false;
            try
            {
                if (optionsMenuBasicMenu.Displayed && optionsMenuBasicMenu.Enabled)
                {
                    itenBasicMenu.Click();
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Invalid returned options";
                    _result = false;
                }

            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }
            return _result;
        }

    }
}
