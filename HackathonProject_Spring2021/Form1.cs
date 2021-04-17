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
    public partial class Form1 : Form
    {
        String OrderBox = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test

        }

        private void richTextBox_output_TextChanged(object sender, EventArgs e)
        {

        }

        //Entrees
        
        //Chick-fil-A Chicken Sandwitch
        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = OrderBox + "\n" + "1 Chick-fil-A Chicken Sandwitch                                      $3.00";
        }

        //Chick-fil-A Deluxe Sandwitch
        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = "\n" + "1 Chick-fil-A Deluxe Sandwitch                                        $3.00";
        }

        //Spicy Chicken Sandwitch
        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = "\n" + "1 Spicy Chicken Sandwitch                                             $3.00";
        }

        //Spicy Deluxe Sandwitch
        private void button4_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = "\n" + "1 Spicy Deluxe Sandwitch                                               $3.00";
        }

        //Grilled Chicken Sandwitch
        private void button5_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = "\n" + "1 Grilled Chicken Sandwitch                                            $3.00";
        }

        //Chick-fil-A Grilled Chicken Club Sandwitch
        private void button6_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = "\n" + "1 Chick fil-A Grilled Chicken Club Sandwitch                   $3.00";
        }

        //Grilled Spicy Deluxe
        private void button7_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = "\n" + "1 Grilled Spicy Deluxe                                                      $3.00";
        }

        //Chick-fil-A Nuggets
        private void button8_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = "\n" + "1 Chick-fil-A Nuggets                                                       $3.00";
        }

        //Grilled Nuggets
        private void button9_Click(object sender, EventArgs e)
        {
            this.richTextBox_output.Text = "\n" + "1 Grilled Nuggets                                                             $3.00";
        }

        
    }
}
