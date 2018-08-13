using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class NavigationElementsMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-title-spacer' and text()='Basic menu']/../..//menu-overview-example[@class='ng-star-inserted']")]
        [CacheLookup]
        public IWebElement basicMenu { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-title-spacer' and text()='Basic menu']/../..//menu-overview-example[@class='ng-star-inserted']/../../../../..")]
        [CacheLookup]
        public IWebElement divBasicMenu { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='cdk-overlay-pane']")]
        [CacheLookup]
        public IWebElement optionsMenuBasicMenu { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='cdk-overlay-pane']//div//button[text()='Item 1']")]
        [CacheLookup]
        public IWebElement itenBasicMenu { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-title-spacer' and text()='Stepper overview']/../following-sibling::div//button/span[text()='Enable linear mode']/..")]
        [CacheLookup]
        public IWebElement buttonEnableLinearMode { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-title-spacer' and text()='Stepper overview']/../following-sibling::div//div[@class='mat-step-label' and text()='Done']")]
        [CacheLookup]
        public IWebElement itenDisable { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-wrapper']")]
        [CacheLookup]
        public IWebElement divButtonEnableLinearMode { get; set; }                    

    }
}
