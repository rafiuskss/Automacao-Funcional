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
                util.WaitForElementVisible(autocompleteInput, 5);
                util.ScrollElementoPage(divAutocomplete);
                autocompleteInput.Click();               
                autocompleteInput.SendKeys(arg);
                util.WaitForElementVisible(autocompleteOptions[0],5);
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
            
            }
        }       

        public void InsertEmail(string arg)
        {
            try
            {
                util.WaitForElementVisible(inputEmail, 10);
                util.ScrollElementoPage(divInputEmail);
                inputEmail.Click();
                inputEmail.SendKeys(arg);
                Thread.Sleep(2000);
            }
            catch (Exception)
            {

            }
        }

        public void OpenCalendar()
        {
            try
            {
                util.WaitForElementVisible(buttonOpenCalendar, 5);
                if (buttonOpenCalendar.Enabled && buttonOpenCalendar.Displayed)
                {                    
                    buttonOpenCalendar.Click();
                    Thread.Sleep(1000);
                }
            }
            catch (Exception)
            {

            }
        }

        public void SelectIten(string arg)
        {
            try
            {
                util.WaitForElementVisible(fieldSelect, 10);
                util.ScrollElementoPage(divFieldSelect);
                fieldSelect.Click();
                Thread.Sleep(500);
                ClassDriver.GetInstance().Driver.FindElement(By.XPath("//span[@class='mat-option-text' and text()='" + arg + "']")).Click();               
                Thread.Sleep(1000);
            }
            catch (Exception)
            {

            }
        }

        public bool ValidCalendar()
        {
            bool _result = false;
            try
            {
                 if(calendarPicker.Enabled && calendarPicker.Displayed)
                {                    
                    Thread.Sleep(1000);
                    ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='mat-calendar-body-cell-content' and text()='" + DateTime.Now.AddDays(-1).ToString("dd") + "']")).Click();                    
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Calendar not opened";
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }

            return _result;
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

        public bool ValidInsertEmail()
        {
            bool _result = false;
            try
            {
                if (inputEmail.Enabled && inputEmail.Displayed)
                {                    

                    try
                    {
                        if (alertErrorEmail.Enabled && alertErrorEmail.Displayed)
                        {
                            ClassInfo.GetInstance().LogMessage = alertErrorEmail.Text;
                        }
                    }
                    catch (Exception)
                    {
                        _result = true;
                    }
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }
            return _result;
        }

        public bool ValidSelect(string arg)
        {
            bool _result = false;
            try
            {

                if (optionSelected.Text.Contains(arg))
                {
                    util.ScrollElementoPage(divFieldSelect);                    
                    _result = true;
                }
                else
                {
                    ClassInfo.GetInstance().LogMessage = "Option selected:" + optionSelected.Text.Split(':')[1] + " Option expected:" + arg;
                }

            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error on validate";
            }
            return _result;
        }

    }
}
