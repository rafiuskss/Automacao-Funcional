using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class DataTableElementsMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@material-docs-example='table-pagination']")]
        [CacheLookup]
        public IWebElement divTable { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@class='mat-paginator-navigation-next mat-icon-button']")]
        [CacheLookup]
        public IWebElement nextPageButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='mat-paginator-range-label']")]
        [CacheLookup]
        public IWebElement nextPageIndicator { get; set; }
        
    }
}
