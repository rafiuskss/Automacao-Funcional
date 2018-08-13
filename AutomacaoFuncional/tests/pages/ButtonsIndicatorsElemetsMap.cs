using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class ButtonsIndicatorsElemetsMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-title-spacer' and text()='Basic button-toggles']/../..//button[@id='mat-button-toggle-1-button' and @aria-pressed='false']")]
        [CacheLookup]
        public IWebElement buttonToggle { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@material-docs-example='button-toggle-overview']")]
        [CacheLookup]
        public IWebElement divButtonToggle { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-title-spacer' and text()='Basic button-toggles']/../..//button[@id='mat-button-toggle-1-button' and @aria-pressed='true']")]
        [CacheLookup]
        public IWebElement buttonToggleSelected { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-title-spacer' and text()='Chips with input']/../..//input")]
        [CacheLookup]
        public IWebElement inputNewChips { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@material-docs-example='chips-input']")]
        [CacheLookup]
        public IWebElement divInputNewChips { get; set; }
        

    }
}
