using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class FormControlsElementsMap
    {
        [FindsBy(How = How.ClassName, Using = "mat-option-text")]
        [CacheLookup]
        public IList<IWebElement> autocompleteOptions { get; set; }

        [FindsBy(How = How.Id, Using = "mat-input-1")]
        [CacheLookup]
        public IWebElement autocompleteInput { get; set; }
    }
}
