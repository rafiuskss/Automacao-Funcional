using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.utils
{
    class ClassUtilities
    {

        public bool WaitForElementVisible(IWebElement element, int timeoutSecond)
        {
            int count = 0;

            do
            {
                try
                {
                    return element.Displayed && element.Enabled;
                }
                catch (Exception)
                {
                    Thread.Sleep(250);
                    count++;
                }

            } while (count < timeoutSecond * 4);

            return false;

        }       

        public void ScrollElementoPage(IWebElement element)
        {
            try
            {

                Point point = new Point();

                if (element != null)
                {
                    point = element.Location;
                    IJavaScriptExecutor js = ClassDriver.GetInstance().Driver as IJavaScriptExecutor;

                    js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                    //js.ExecuteScript("window.scrollBy(" + (point.Y - space) + ");");

                }
            }
            catch (Exception)
            {
            }
        }

        public void SendKeyJS(IWebElement element, string value)
        {
            try
            {
                IJavaScriptExecutor js = ClassDriver.GetInstance().Driver as IJavaScriptExecutor;
                js.ExecuteScript("arguments[0].setAttribute('value', '" + value + "')", element);
            }
            catch (Exception)
            {

            }
           
        }

        public void ClickJS(IWebElement element)
        {
            try
            {
                IJavaScriptExecutor js = ClassDriver.GetInstance().Driver as IJavaScriptExecutor;
                js.ExecuteScript("arguments[0].Click()", element);
            }
            catch (Exception)
            {

            }

        }
    }
}
