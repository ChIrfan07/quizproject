using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace quizproject
{
    [TestClass]
    public class UnitTest1 : browser
    {

        [TestInitialize()]

        public void TestInit()

        {

            browser.SeleniumInit("Chrome");

        }
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }



        //[TestMethod, TestCategory("Signup")]

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Signupp.xml", "Signup", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestMethod1()

        {
            browser.OpenUrl("https://automationexercise.com");

            //string user = TestContext.DataRow["username"].ToString();

            //string email = TestContext.DataRow["email"].ToString();

            registration regi = new registration();
            regi.reg("Muhammad Irfan", "crispyice666676@yahoo.com", "123456789", "Muhammad", "Irfan", "Contour", "c1", "d1", "Punjab", "lahore", "5440", "1234567789");
            //regi.reg(user, email);

            string actual = driver.FindElement(By.XPath("//i[@class='fa fa-user']")).Text;
            Assert.AreEqual(" Logged in as Muhammad Irfan", actual);

        }

        [TestMethod]

        public void loginnn()
        {
            browser.OpenUrl("https://automationexercise.com");
            login loog = new login();
            loog.logg("crispyice12366@gmail.com","123456789");
            string actual = driver.FindElement(By.XPath("//i[@class='fa fa-user']")).Text;
            Assert.AreEqual(" Logged in as Muhammad Irfan", actual);
        }

        [TestMethod]

        public void logoutt()
        {
            browser.OpenUrl("https://automationexercise.com");
            logout lt = new logout();
            lt.logouttt("crispyice12366@gmail.com", "123456789");

            string actual = driver.FindElement(By.XPath("//i[@class='fa fa-user']")).Text;
            Assert.AreEqual(" Logged in as Muhammad Irfan", actual);
        }

        [TestMethod]

        public void addtocart()
        {
            browser.OpenUrl("https://automationexercise.com");
            order oo = new order();
            oo.cart("Muhammad Irfan", "chaudharyirfan038888@gmail.com", "123456789", "Muhammad", "Irfan", "Contour", "c1", "d1", "Punjab", "lahore", "5440", "1234567789" , "Blue top","Irfan" , "12345" ,"121" , "June" ,"2023");

            // registration regi = new registration();
            //regi.reg("Muhammad Irfan", "crispyice12366@yahoo.com", "123456789", "Muhammad", "Irfan", "Contour", "c1", "d1", "Punjab", "lahore", "5440", "1234567789");

            //string actual = driver.FindElement(By.XPath("//i[@class='fa fa-user']")).Text;
            //Assert.AreEqual(" Logged in as Muhammad Irfan", actual);
        }

        [TestMethod]

        public void verifytocart()
        {
            browser.OpenUrl("https://automationexercise.com");
            verifyproduct oo = new verifyproduct();
            oo.verify("4");

           
        }






    }
}