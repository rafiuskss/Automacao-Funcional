﻿using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class AccessPageActions : AccessElementsMap
    {
        private ClassUtilities util = new ClassUtilities();

        public AccessPageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void AccessPage(string url)
        {           
            ClassDriver.GetInstance().Driver.Navigate().GoToUrl(url);
        }

        public bool ValidAccessPage()
        {
            bool _result = false;
            try
            {

                util.WaitForElementVisible(menuHeaderHome, 10);

                if (menuHeaderHome.Enabled && menuHeaderHome.Displayed)
                {
                    util.HigthLine(menuHeaderHome);
                    _result = true;
                }               
            }
            catch (Exception)
            {

            }
            return _result;
        }
    }
}