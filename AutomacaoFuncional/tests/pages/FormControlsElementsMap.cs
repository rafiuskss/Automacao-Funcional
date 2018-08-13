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


        [FindsBy(How = How.Id, Using = "mat-datepicker-0")]
        [CacheLookup]
        public IWebElement calendarPicker { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[text()='Basic datepicker']/../following-sibling::div//button")]
        [CacheLookup]
        public IWebElement buttonOpenCalendar { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='mat-form-field-infix']/input[@placeholder='Email']")]
        [CacheLookup]
        public IWebElement inputEmail { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='mat-form-field-subscript-wrapper']//mat-error")]
        [CacheLookup]
        public IWebElement alertErrorEmail { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='docs-example-viewer-title-spacer' and text()='Select with 2-way value binding']/../following-sibling::div//mat-select")]
        [CacheLookup]
        public IWebElement fieldSelect { get; set; }


        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'You selected:')]")]
        [CacheLookup]
        public IWebElement optionSelected { get; set; }

        
    }
}
