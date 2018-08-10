using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class AccessElementsMap
    {

        [FindsBy(How = How.ClassName, Using = "docs-navbar-header")]
        [CacheLookup]
        public IWebElement menuHeaderHome { get; set; }
    }
}
