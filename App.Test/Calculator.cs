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
    [Ignore("Ignore this test case when commit because NUNitForms doesn't support when build on Travis")]
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
    }
}
