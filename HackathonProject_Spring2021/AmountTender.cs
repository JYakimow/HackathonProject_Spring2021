using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonProject_Spring2021
{
    public partial class AmountTender : Form
    {
        public AmountTender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_QC5_Click(object sender, EventArgs e)
        {
            // substracts 5 dollars from total 
        }

        private void button_QC10_Click(object sender, EventArgs e)
        {
            // substracts 10 dollars from total
        }

        private void button_QC15_Click(object sender, EventArgs e)
        {
            // substracts 15 dollars from total
        }

        private void button_custom_Click(object sender, EventArgs e)
        {
            // enter in amount of cash being paid
        }
    }
}
