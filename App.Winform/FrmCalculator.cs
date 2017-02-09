using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Winform
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            var num1 = int.Parse(txtNum1.Text);
            var num2 = int.Parse(txtNum2.Text);
            lblResult.Text = (num1 + num2).ToString();
        }
    }
}
