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
        double input;
        double rt;
        double ft = 10;
        
    

        
        private void AmountTender_Load(object sender, EventArgs e)
        {
            textBox_custom.Select();
            textBox_custom.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_QC5_Click(object sender, EventArgs e)
        {
            // substracts 5 dollars from the total underneath Pay Full Amount (running total or label_rt) 
            rt += -5.00;
            textBox_rt.Text = rt.ToString();
        }

        private void button_QC10_Click(object sender, EventArgs e)
        {
            // substracts 10 dollars from the total underneath Pay Full Amount (running total or label_rt) 

            rt += -10.00;
            textBox_rt.Text = rt.ToString();

        }

        private void button_QC15_Click(object sender, EventArgs e)
        {
            // substracts 15 dollars from the total underneath Pay Full Amount (running total or label_rt) 
            rt += -15.00;
            textBox_rt.Text = rt.ToString();
        }

        private void button_giftcard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Completed");
        }

        private void button_card_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaction Completed");
        }

        private void button_manual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Enter Card");
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter Check Info");
        }

        private void button_payCash_Click(object sender, EventArgs e)
        {
            // subtracts entered amount from textBox_custom (button next to it) to label_rt or running total
            // Not total in the above box
            // subtracts 
            try
            {
                input = Convert.ToDouble(textBox_custom.Text);
                if (input > 0)
                {
                    rt -= Convert.ToDouble(textBox_custom.Text);
                    textBox_rt.Text = rt.ToString();
                    textBox_custom.Text = "";
                    textBox_custom.Text = string.Empty;
                    textBox_custom.Focus();

                }
                else
                {
                    textBox_custom.Text = "Error on Input, Only Numeric Values Greater than 0";
                    textBox_custom.Text = " "; // gets rid of incorrect input
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Input, only positive numbers expected.");

            }
        }

        private void textBox_custom_TextChanged(object sender, EventArgs e)
        {
            //enter custom amount of cash being paid, will substract from the total underneath Pay Full Amount(running total or label_rt)

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            textBox_custom.Text = string.Empty;
            textBox_rt.Text = string.Empty;
            textBox_rt.Text = textBox_total.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //made to keep original balance of the bill

    }
    }

