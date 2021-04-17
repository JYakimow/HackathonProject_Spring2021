using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace HackathonProject_Spring2021
{
    public partial class Form1 : Form
    {
        int quanitity = 1;
        double total = 0;
        double Amount = 0;
        double tempPrice = 0;

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
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Chick-fil-A Chicken Sandwitch-" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: " + total;
        }

        //Chick-fil-A Deluxe Sandwitch
        private void button2_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            this.richTextBox_output.Text = "\n" + " " + quanitity + " Chick-fil-A Deluxe Sandwich-" + tempPrice;
            this.total_label.Text = "Total: " + total;
        }

        //Spicy Chicken Sandwitch
        private void button3_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            this.richTextBox_output.Text = "\n" + " " + quanitity + " Spicy Chicken Sandwitch-" + tempPrice;
            this.total_label.Text = "Total: " + total;
        }

        //Spicy Deluxe Sandwitch
        private void button4_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            this.richTextBox_output.Text = "\n" + " " + quanitity + " Spicy Deluxe Sandwitch-" + tempPrice;
            this.total_label.Text = "Total: " + total;
        }

        //Grilled Chicken Sandwitch
        private void button5_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            this.richTextBox_output.Text = "\n" + " " + quanitity + " Grilled Chicken Sandwitch-" + tempPrice;
            this.total_label.Text = "Total: " + total;
        }

        //Chick-fil-A Grilled Chicken Club Sandwitch
        private void button6_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            this.richTextBox_output.Text = "\n" + " " + quanitity + " Chick fil-A Grilled Chicken Club Sandwitch-" + tempPrice;
            this.total_label.Text = "Total: " + total;
        }

        //Grilled Spicy Deluxe
        private void button7_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            this.richTextBox_output.Text = "\n" + " " + quanitity + " Grilled Spicy Deluxe-" + tempPrice;
            this.total_label.Text = "Total: " + total;
        }

        //Chick-fil-A Nuggets
        private void button8_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            this.richTextBox_output.Text = "\n" + " " + quanitity + " Chick-fil-A Nuggets-" + tempPrice;
            this.total_label.Text = "Total: " + total;
        }

        //Grilled Nuggets
        private void button9_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * 3.00;
            total = total + tempPrice;
            this.richTextBox_output.Text = "\n" + " " + quanitity + " Grilled Nuggets-" + tempPrice;
            this.total_label.Text = "Total: " + total;
        }



        private void button_qty1_Click(object sender, EventArgs e)
        { 
        }
        private void button_mgr_Click(object sender, EventArgs e)
        {
            mgr_Form();
        }

        public void mgr_Form()
        {
            ManagerMenu mgrMenu = new ManagerMenu();
            mgrMenu.ShowDialog();            
        }

        private void button_testBurger_Click(object sender, EventArgs e)
        {
            //Form_askEdit formAskEdit = new Form_askEdit();
            //formAskEdit.Show();
        }

        

        private void listBox1_items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_testBurger_Click_1(object sender, EventArgs e)
        {
            //Form_askEdit formAskEdit = new Form_askEdit();
            //formAskEdit.ShowDialog();
            this.richTextBox_output.Text = "test burger";
        }

        private void button_qty1_Click_1(object sender, EventArgs e)
        {
            quanitity = 1;
        }

        private void button_qty2_Click(object sender, EventArgs e)
        {
            quanitity = 2;
        }

        private void button_qty3_Click(object sender, EventArgs e)
        {
            quanitity = 3;
        }

        private void button_qty4_Click(object sender, EventArgs e)
        {
            quanitity = 4;
        }

        private void button_qty5_Click(object sender, EventArgs e)
        {
            quanitity = 5;
        }

        private void button_qty6_Click(object sender, EventArgs e)
        {
            quanitity = 6;
        }

        private void button_qty7_Click(object sender, EventArgs e)
        {
            quanitity = 7;
        }

        private void button_qty8_Click(object sender, EventArgs e)
        {
            quanitity = 8;
        }

        private void button_qtyCustom_Click(object sender, EventArgs e)
        {

        }

        private void total_label_Click(object sender, EventArgs e)
        {
            
        }
    }
}
