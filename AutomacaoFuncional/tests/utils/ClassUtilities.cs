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

        public void HigthLine(IWebElement locator)
        {
            try
            {
                ScrollElementoPage(locator);
                Point point = new Point();
                //#00FF00

                if (locator != null)
                {
                    point = locator.Location;
                    IJavaScriptExecutor js = ClassDriver.GetInstance().Driver as IJavaScriptExecutor;

                    js.ExecuteScript("window.scrollBy(0," + (point.Y - 10) + ");");
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", locator);

                }
                IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)ClassDriver.GetInstance().Driver;
                javaScriptExecutor.ExecuteScript("arguments[0].setAttribute('style', arguments[1]);",
                locator, "outline: 4px solid #00FF00;");

            }
            catch (Exception) { }

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

    }
}
