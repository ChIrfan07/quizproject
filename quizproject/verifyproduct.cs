using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace quizproject
{
    class verifyproduct : browser
    {
        By product = By.XPath("//i[@class='fa fa-plus-square']");

        By quat = By.Id("quantity");
        //By qut = By.XPath("//input[@value()='4']");

        By add = By.XPath("//button[@class='btn btn-default cart']");

        By view = By.XPath("//u[text()='View Cart']");


        public void verify(string quantity)
        {
            Click(product);
            Clear(quat);
            Write(quat, quantity);
            //Click(qut);

            Thread.Sleep(2000);
            Click(add);
            Thread.Sleep(1000);

            Click(view);
        }
    }
}
