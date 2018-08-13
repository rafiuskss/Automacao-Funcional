using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class FormControlsPageActions : FormControlsElementsMap
    {
        private ClassUtilities util = new ClassUtilities();

        public FormControlsPageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void AutocompleteTeste(string arg)
        {
            try
            {
                util.ScrollElementoPage(autocompleteInput);
                autocompleteInput.Click();               
                autocompleteInput.SendKeys(arg);
                util.WaitForElementVisible(autocompleteOptions[0],5);
            }
            catch (Exception)
            {
            
            }
        }

        public bool ValidAutocomplete(int arg)
        {
            bool _return = false;
            try
            {
                if (autocompleteOptions.Count == arg)
                {
                    _return = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Options returned invalids";
                }                               

            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }

            return _return;
        }

    }
}
