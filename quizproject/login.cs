using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizproject
{
    public class login : browser
    {
        By log = By.XPath("//i[@class='fa fa-lock']");
        By eeemail = By.XPath("//input[@data-qa='login-email']");
        By nameee = By.Name("password");
        By loginn = By.XPath("//button[text()='Login']");
        By del = By.XPath("//i[@class='fa fa-trash-o']");


        public void logg(string email, string password)
        {
            Click(log);
            Write(eeemail, email);
            Write(nameee, password);
            Click(loginn);
            Click(del);
        }
    }
}
