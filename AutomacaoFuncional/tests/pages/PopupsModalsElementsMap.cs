using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class PopupsModalsElementsMap
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='mat-form-field-infix']//input")]
        [CacheLookup]
        public IWebElement inputNamePickOne { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@material-docs-example='dialog-overview']")]
        [CacheLookup]
        public IWebElement divInputNamePickOne { get; set; }
       

        [FindsBy(How = How.ClassName, Using = "mat-raised-button")]
        [CacheLookup]
        public IWebElement buttonPickOne { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[@class='mat-button-wrapper' and text()='Ok']")]
        [CacheLookup]
        public IWebElement buttonOkDialog { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='mat-form-field-flex']//input[@placeholder='Message']")]
        [CacheLookup]
        public IWebElement inputTextSnackBar { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@class='mat-button']//span[text()='Show snack-bar']/..")]
        [CacheLookup]
        public IWebElement buttonShowSnackBar{ get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@material-docs-example='snack-bar-overview']")]
        [CacheLookup]
        public IWebElement divButtonShowSnackBar { get; set; }



    }
}
