﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prj_test.PageObjects
{
    /// <summary>
    /// Login Page
    /// </summary>
     class LoginPage_PageObj
    {
        /// <summary>
        /// User Data for Test
        /// </summary>
        public static class Logs
        {

            public struct data
            {
                public string email;
                public string pass;
                /// <summary>
                /// Construct struct user data
                /// </summary>
                /// <param name="_email">Email user</param>
                /// <param name="_pass">Password user</param>
                public data(string _email, string _pass)
                {
                    email = _email;
                    pass = _pass;
                }
            }
            /// <summary>
            /// Users data array
            /// </summary>
            static public data[] arr_data ={
            new data("testing@sibelcom54.com","Test2020!"),
            new data("testing_2@sibelcom54.com","Test2020!"),
            new data("sk@sibelcom54.com", "2206SK")
        };
        }
        /// <summary>
        /// Length Data array(Login_FormPageObj/@class=log)
        /// </summary>
        public int Length;

        private readonly  By button_sign = By.XPath("//input[@name='submit']");

        private readonly  By input_email = By.XPath("//input[@name='email']");
        private readonly  By input_pass = By.XPath("//input[@type='password']");
        private  IWebDriver _webDriver;
        public  LoginPage_PageObj(IWebDriver webDriver) {
            _webDriver = webDriver;
            Length = Logs.arr_data.Length;
        }
        /// <summary>
        /// Sign in 
        /// </summary>
        /// <param name="num">Number of data(Logs.cs)</param>
        /// <returns></returns>
        public NavigationBar_PageObj Sign_in(int num) {
            _webDriver.FindElement(input_email).SendKeys(Logs.arr_data[num].email);
            _webDriver.FindElement(input_pass).SendKeys(Logs.arr_data[num].pass);
            _webDriver.FindElement(button_sign).Click();
            return new CalendarPage_PageObj(_webDriver);
        }
    }
}
