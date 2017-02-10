using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace App.Test
{
    [TestFixture(Author = "PhongTV", Description = "Testing for function login"), Description("Testing function login")]
    public class Login
    {
        private string email = string.Empty;
        private string password = string.Empty;
        private string regEmail = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        [SetUp]
        public void Initial()
        {
            email = "abc@gmail.com";
            password = "1234567";
        }

        [TestCase]
        public void CheckNullEmail()
        {
            Assert.IsNotEmpty(email, "Please enter your email.");
        }

        [TestCase]
        public void CheckNullPassword()
        {
            Assert.IsNotEmpty(password, "Please enter your password.");
        }

        [TestCase]
        public void ValidateEmail()
        {
            bool isEmail = Regex.IsMatch(email,regEmail, RegexOptions.IgnoreCase);
            Assert.IsTrue(isEmail, "Please enter email correct.");
        }

        [TestCase]
        public void CheckPasswordLength()
        {
            Assert.Greater(password.Length, 6, "The password must be at least 6 characters.");
        }
    }
}
