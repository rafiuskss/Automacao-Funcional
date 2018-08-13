using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class MenuPageActions
    {
        public bool AccessMenu(string menuName)
        {
            bool _result = false;
            try
            {
                string argMenu = menuName.Split('>')[0].Trim();
                string argSubMenu = menuName.Contains(">") ? menuName.Split('>')[1].Trim() : null;

                IWebElement menu = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//div[@class='docs-component-category-list']//a//mat-card-title[text()='" + argMenu + "']"));

                if (menu.Displayed && menu.Enabled)
                {
                    new ClassUtilities().HigthLine(menu);
                    menu.Click();

                    if (argSubMenu != null)
                    {
                        IWebElement subMenu = ClassDriver.GetInstance().Driver.FindElement(By.XPath("//mat-card-title[@class='docs-component-list-card-title mat-card-title' and text()='" + argSubMenu + "']"));

                        if (subMenu.Displayed && subMenu.Enabled)
                        {
                            new ClassUtilities().HigthLine(subMenu);
                            subMenu.Click();

                        }
                    }

                    _result = true;
                }
            }
            catch (Exception ex)
            {
                ClassInfo.GetInstance().LogMessage = "Menu or SubMenu:" + menuName + "not visible or enable.";
            }
            return _result;
        }


    }
}
