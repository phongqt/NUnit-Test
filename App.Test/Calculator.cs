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
    [TestFixture]
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
