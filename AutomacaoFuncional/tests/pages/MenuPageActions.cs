using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{    

    class MenuPageActions
    {

        private ClassUtilities util = new ClassUtilities();

        public void AccessMenu(string menuName)
        {
            try
            {

                IWebElement menu = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//button[@class='docs-nav-content-btn' and text()='" + menuName + "']"));               

                if (menu.Displayed && menu.Enabled)
                {
                    util.ScrollElementoPage(menu);
                    menu.Click();
                    Thread.Sleep(500);
                    
                    if (menu.GetAttribute("aria-expanded").Equals("false"))
                    {
                        menu.Click();
                    }
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Menu:" + menuName + "not visible or enable.";
            }
        }
      
        public void AccessSubMenu(string subMenuName)
        {

            try
            {
                IWebElement subMenu = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//a[@class='ng-tns-c12-2' and text()='" + subMenuName + "']"));
                
                if (subMenu.Displayed && subMenu.Enabled)
                {
                    util.ScrollElementoPage(subMenu);
                    subMenu.Click();                
                }
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Menu or SubMenu:" + subMenuName + "not visible or enable.";
            }
        }

    }
}
