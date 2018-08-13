using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class DataTablePageActions : DataTableElementsMap
    {

        private ClassUtilities util = new ClassUtilities();

        public DataTablePageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void ClickNextPage()
        {
            try
            {
                util.WaitForElementVisible(nextPageButton, 10);

                if (nextPageButton.Enabled && nextPageButton.Displayed)
                {
                    util.ScrollElementoPage(divTable);
                    nextPageButton.Click();
                }
            }
            catch (Exception)
            {

            }
        }

        public bool ValidNextPage()
        {
            bool _result = false;
            try
            {

                util.WaitForElementVisible(nextPageIndicator, 10);

                if (nextPageIndicator.Enabled && nextPageIndicator.Displayed)
                {
                    _result = nextPageIndicator.Text.Equals("6 - 10 of 20");
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Redirect next page invalid";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error accessing the page";
            }
            return _result;
        }
    }
}
