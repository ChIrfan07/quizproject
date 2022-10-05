using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace quizproject
{
   public class order : browser
    {
        By product = By.XPath("//i[@class='fa fa-plus-square']");

        By add = By.XPath("//button[@class='btn btn-default cart']");

        By cont = By.XPath("//button[@class='btn btn-success close-modal btn-block']");

        By carttt = By.XPath("//i[@class='fa fa-shopping-cart']");

        By proceed = By.XPath("//a[@class='btn btn-default check_out']");

        By reg = By.XPath("//u[text()='Register / Login']");

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
        By stat = By.Id("state");
        By cit = By.Id("city");
        By zip = By.Id("zipcode");
        By mobile = By.Id("mobile_number");
        By acc = By.XPath("//button[text()='Create Account']");
       By contt = By.XPath("//a[text()='Continue']");

        By carp = By.XPath("//i[@class='fa fa-shopping-cart']");
        By proceedd = By.XPath("//a[@class='btn btn-default check_out']");
        By mess = By.Name("message");

       By check = By.XPath("//a[@class='btn btn-default check_out']");

        By n1 = By.Name("name_on_card");

        By n2 = By.Name("card_number"); 

        By cvc = By.Name("cvc");

      By expiry = By.Name("expiry_month");

        By expiryy = By.Name("expiry_year");

       By place = By.XPath("//a[@class='form-control btn btn-primary submit-button']");

        By voice = By.XPath("//a[text()='Download Invoice']");

        By ct = By.XPath("//a[text()='Continue']");

        public void cart(string name, string email, string password, string firstname, string lastname, string comapny, string address1, string address2, string state, string city, string zipcode, string mob , string msg , string name1 , string card , string cvc1 , string expiry1 , string expiry2)
        {
            Click(product);
            Click(add);
            Thread.Sleep(3000);
            Click(cont);
            Click(carttt);
            Click(proceed);
            Click(reg);

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
            Write(lname, lastname);
            Write(comp, comapny);
            Write(add1, address1);
            Write(add2, address2);
            Click(country);
            Write(stat, state);
            Write(cit, city);
            Write(zip, zipcode);
            Write(mobile, mob);
            Click(acc);
            Click(zip);
            Thread.Sleep(2000);
            Click(contt);


            Click(carp);
            Click(proceedd);
            Write(mess, msg);
            Click(check);
            Write(n1, name1);
            Write(n2, card);
            Write(cvc, cvc1);
            Write(expiry, expiry1);
            Write(expiryy, expiry2);
            Click(place);
            Click(voice);
            Click(ct);
        }
    }


}
