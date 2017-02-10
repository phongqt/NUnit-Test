using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Extensions;
using App.Winform;
using NUnit.Extensions.Forms;

namespace App.Test
{
    [TestFixture(Author ="PhongTV", Description ="Testing for winform")]
    //[Ignore("Ignore this test case when commit because NUNitForms doesn't support when build on Travis")]
    public class Calculator
    {
        private FrmCalculator frmCalculator;

        [SetUp]
        public void Initial()
        {
            frmCalculator = new FrmCalculator();
            frmCalculator.Show();
        }

        [Test]
        public void InitialForm()
        {            
            Assert.AreEqual("Calculator", frmCalculator.Text);
        }

        [Test]
        public void InitialControls()
        {
            LabelTester num1 = new LabelTester("lblNum1", frmCalculator);
            LabelTester num2 = new LabelTester("lblNum2", frmCalculator);
            ButtonTester submitButton = new ButtonTester("btnCal", frmCalculator);

            Assert.AreEqual("Number 1", num1.Text);
            Assert.AreEqual("Number 2", num2.Text);
            Assert.AreEqual("Submit", submitButton.Text);
        }

        [Test]
        public void TestEvent()
        {
            TextBoxTester txtNum1 = new TextBoxTester("txtNum1", frmCalculator);
            TextBoxTester txtNum2 = new TextBoxTester("txtNum2", frmCalculator);
            ButtonTester submitButton = new ButtonTester("btnCal", frmCalculator);

            Assert.AreEqual("Submit", submitButton.Text);

            txtNum1.Properties.Text = "4";
            txtNum2.Properties.Text = "1";

            submitButton.Click();
            LabelTester lblResult = new LabelTester("lblResult", frmCalculator);
            Assert.AreEqual("5", lblResult.Text);
        }
    }
}
