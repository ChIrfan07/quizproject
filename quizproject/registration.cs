using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizproject
{
    public class registration : browser
    {
        By log = By.XPath("//i[@class='fa fa-lock']");
        By namee = By.Name("name");
        By eemail = By.XPath("//input[@data-qa='signup-email']");
        By sub = By.XPath("//button[text()='Signup']");
        By title = By.Id("id_gender1");
        By pass = By.Id("password"); 
        By dob = By.Id("days");
        By dob1 = By.XPath("//option[text()='26']");
        By mon = By.Id("months");
        By month = By.XPath("//option[text()='May']");
        By year = By.Id("years"); 
        By year1 = By.XPath("//option[text()='1997']");
       By news = By.Id("newsletter");
        By opt = By.Id("optin"); 
        By fname = By.Id("first_name");
        By lname = By.Id("last_name");
        By comp = By.Id("company");
        By add1 = By.Id("address1");
        By add2 = By.Id("address2"); 
        By country = By.XPath("//option[text()='Canada']");
      By stat= By.Id("state");
        By cit = By.Id("city");
        By zip = By.Id("zipcode");
        By mobile = By.Id("mobile_number");
        By acc = By.XPath("//button[text()='Create Account']");
        By contin = By.XPath("//a[@data-qa='continue-button']");
        By delete = By.XPath("//i[text()='Delete Account']");
        //By cont = By.XPath("//a[@data-qa='continue-button']//parent::div");
        // By cont = By.XPath("//div[@class='pull-right']//child::a");
     //   By del = By.XPath("//i[@class='fa fa-trash-o']");
        public void reg(string name,string email,string password , string firstname, string lastname, string comapny,string address1 ,string address2, string state,string city,string zipcode, string mob)
        {
            Click(log);
            Write(namee, name);
            Write(eemail, email);
            Click(sub);
            Click(title);
            Write(pass, password);
            Click(dob);
            Click(dob1);
            Click(mon);
            Click(month);
            Click(year);
            Click(year1);
            Click(news);
            Click(opt);
            Write(fname, firstname);
            Write(lname,lastname);
            Write(comp, comapny);
            Write(add1, address1);
            Write(add2, address2);
            Click(country);
            Write(stat, state);
            Write(cit,city);
            Write(zip, zipcode);
            Write(mobile,mob);
            Click(acc);
            Click(zip);
            Click(contin);
          //  Click(del);
          
        }
    }
}
