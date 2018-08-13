using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class ButtonsIndicatorsPageActions : ButtonsIndicatorsElemetsMap
    {
        private ClassUtilities util = new ClassUtilities();

        public ButtonsIndicatorsPageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void ClickButtonToggle()
        {
            try
            {
                util.WaitForElementVisible(buttonToggle, 10);

                if (buttonToggle.Enabled && buttonToggle.Displayed)
                {
                    util.ScrollElementoPage(divButtonToggle);
                    buttonToggle.Click();
                }
            }
            catch (Exception)
            {

            }
        }

        public void InsertNewChips(string arg)
        {
            try
            {
                util.WaitForElementVisible(inputNewChips, 15);

                if (inputNewChips.Enabled && inputNewChips.Displayed)
                {
                    util.ScrollElementoPage(divInputNewChips);
                    inputNewChips.SendKeys(arg);
                    inputNewChips.SendKeys(OpenQA.Selenium.Keys.Enter);
                }
            }
            catch (Exception)
            {

            }
        }

        public bool ValidNewChips(string arg)
        {
            bool _result = false;
            try
            {
                IWebElement insertedChips = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='mat-chip-list-wrapper']//mat-chip[text()='" + arg + "']"));

                if (insertedChips.Enabled && insertedChips.Displayed)
                {
                    
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Chips not inserted";
                }

            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }
            return _result;
        }

        public bool ValidButtonToggle()
        {
            bool _result = false;
            try
            {
                if (buttonToggleSelected.Enabled && buttonToggleSelected.Displayed)
                {
                    util.ScrollElementoPage(divButtonToggle);
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "ButtonToggle not selected";
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
