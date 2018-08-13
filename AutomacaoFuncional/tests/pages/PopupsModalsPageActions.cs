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
    class PopupsModalsPageActions : PopupsModalsElementsMap
    {
        private ClassUtilities util = new ClassUtilities();

        public PopupsModalsPageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void InsertTextPickOne(string arg)
        {
            try
            {
                util.WaitForElementVisible(inputNamePickOne, 15);

                if (inputNamePickOne.Enabled && inputNamePickOne.Displayed)
                {
                    util.ScrollElementoPage(divInputNamePickOne);
                    inputNamePickOne.SendKeys(arg);
                }
            }
            catch (Exception)
            {

            }
        }

        public void ClickPickOne()
        {
            try
            {
                if (buttonPickOne.Enabled && buttonPickOne.Displayed)
                {
                    util.ScrollElementoPage(divInputNamePickOne);
                    buttonPickOne.Click();
                }
            }
            catch (Exception)
            {

            }
        }

        public void ClickShowSnackBar()
        {
            try
            {
                if (buttonShowSnackBar.Enabled && buttonShowSnackBar.Displayed)
                {
                    util.ScrollElementoPage(divButtonShowSnackBar);
                    buttonShowSnackBar.Click();
                }
            }
            catch (Exception)
            {

            }
        }

        public void InsertMessageSnackBar(string arg)
        {
            try
            {
                util.WaitForElementVisible(inputTextSnackBar, 15);

                if (inputTextSnackBar.Enabled && inputTextSnackBar.Displayed)
                {
                    util.ScrollElementoPage(divButtonShowSnackBar);
                    inputTextSnackBar.Clear();
                    inputTextSnackBar.SendKeys(arg);
                }
            }
            catch (Exception)
            {

            }
        }

        public bool ValidTextDialog(string arg)
        {
            bool _result = false;
            try
            {
                IWebElement insertedText = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//h1[text()='Hi " + arg + "']"));

                if (insertedText.Enabled && insertedText.Displayed)
                {                    
                    buttonOkDialog.Click();
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Dialog not returned text";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }
            return _result;
        }

        public bool ValidSneckBar(string arg)
        {
            bool _result = false;
            try
            {
                Thread.Sleep(2000);

                IWebElement insertedTextSnackBar = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[text()='" + arg + "']"));                                               
                
                buttonShowSnackBar.Click();

                Thread.Sleep(600);
                util.WaitForElementVisible(insertedTextSnackBar, 15);
                if (insertedTextSnackBar.Enabled && insertedTextSnackBar.Displayed)
                {                   
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "SnackBar not returned message";
                }
            }
            catch (Exception ex)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }
            return _result;

        }


        


    }
}
