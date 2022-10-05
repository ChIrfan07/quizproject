using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizproject
{
    public class browser

    {
       

        public static IWebDriver driver;

        public static IWebDriver SeleniumInit(string browser)
        {

            //driver = new ChromeDriver();
            if (browser == "Chrome")
            {
                ChromeOptions options = new ChromeOptions();

                options.AddArguments("start-maximized");


                // options.AddArguments("headless");


                //  options.AddArguments("incognito");

                //  options.AddArguments("disable-extensions");

                options.AddArguments("disable-popup-blocking");


                return driver = new ChromeDriver(options);


            }
            else if (browser == "Firefox")
            {
                return driver = new FirefoxDriver();
            }
            else if (browser == "Edge")

            {

                return driver = new EdgeDriver();
            }
            return driver;


        }

        public static void Closedriver()

        {

            driver.Close();

        }




        public void Write(By by, string value)
        {

            driver.FindElement(by).SendKeys(value);

        }

        public void Click(By by)
        {
            driver.FindElement(by).Click();

            //Actions action = new Actions(driver);
            //IWebElement element = driver.FindElement(by);
            //action.MoveToElement(element).Click().Perform();


        }

        public void Clear(By by)
        {

            driver.FindElement(by).Clear();

        }

        public static void OpenUrl(string url)
        {

            driver.Url = url;

        }

        public void Selectdrop(By by, String value)
        {
            IWebElement dropdown = driver.FindElement(by);
            SelectElement dropdownmenu = new SelectElement(dropdown);
            dropdownmenu.SelectByValue(value);
        }

    }
}
