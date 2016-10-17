using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 *
 * Name: Mihialo Blade Codilan
 * Teacher: Mr.Hardman
 * Assignment #2, Program #???
 * Date Last Modified: Oct. 14th, 2016
 *
 */

namespace Assignment2
{
    public partial class frmAssignment2 : Form
    {
        public frmAssignment2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGreet_Click(object sender, EventArgs e)
        {

        }

        private void btnResponse_Click(object sender, EventArgs e)
        {
            string answer = txtMood.Text;

            if (answer == "Yes")
            {
                lblResponse.Text = String.Format("Your Answer was:{0,5}\nWell that's pretty chillio cheerio", answer);
            }
            else if (answer == "No")
            {
                lblResponse.Text = String.Format("Your Answer was:{0,5}\nWell that's pretty lamo wamo",  answer );
            }
            else
            {
                lblResponse.Text = String.Format("Your Anwer was:{0,25}\nUmmmmmmmmm..... Whiskey Tango Foxtrot?", answer);
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double Mark1 = Convert.ToDouble(txtMark1.Text) / 100;
            double Mark2 = Convert.ToDouble(txtMark2.Text) / 100;
            double Mark3 = Convert.ToDouble(txtMark3.Text) / 100;
            double Mark4 = Convert.ToDouble(txtMark4.Text) / 100;
            double Mark5 = Convert.ToDouble(txtMark5.Text) / 100;

            double average = (Mark1 + Mark2 + Mark3 + Mark4 + Mark5) / 5;

            lblDisplayAverage.Text = String.Format("{0,16}{1,10:P}\n{2,16}{3,10:P}\n{4,16}{5,10:P}\n{6,16}{7,10:P}\n{8,16}{9,10:P}\n\n{10,16}{11,10:P}", 
            "Grade 1:", Mark1, "Grade 2:", Mark2, "Grade 3:", Mark3, "Grade 4:", Mark4, "Grade 5:", Mark5, "Your Average:", average);
        }

        private void txtMark1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
