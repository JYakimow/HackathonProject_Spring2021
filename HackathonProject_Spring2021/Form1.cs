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
        string OrderBox = "";
        Ingredient[] ingredientArr;

        //MessageBox.Show("test");
        //var test = new Ingredient("test", 1.0);

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //arrays here
            ingredientArr = new Ingredient[11];
            //fill ingredients
            Ingredient Regular_bun = new Ingredient("Regular bun", 0.30);
            ingredientArr[0] = Regular_bun;
            Ingredient WholeWheat_bun = new Ingredient("Whole Wheat bun", 0.20);
            ingredientArr[1] = WholeWheat_bun;
            Ingredient FriedChicken_Patty = new Ingredient("Fried Chicken Patty", 0.30);
            ingredientArr[2] = FriedChicken_Patty;
            Ingredient GrilledChicken_Patty = new Ingredient("Grilled Chicken Patty", 0.40);
            ingredientArr[3] = GrilledChicken_Patty;
            Ingredient Pickles = new Ingredient("Pickles", 0.15);
            ingredientArr[4] = Pickles;
            Ingredient Chedder_Cheese = new Ingredient("Chedder Cheese", 0.30);
            ingredientArr[5] = Chedder_Cheese;
            Ingredient CobyJack_Cheese = new Ingredient("Coby Jack Cheese", 0.30);
            ingredientArr[6] = CobyJack_Cheese;
            Ingredient PepperJack_Cheese = new Ingredient("Pepper Jack Cheese", 0.30);
            ingredientArr[7] = PepperJack_Cheese;
            Ingredient Bacon = new Ingredient("Bacon", 0.10);
            ingredientArr[8] = Bacon;
            Ingredient Tomatoes = new Ingredient("Tomatoes", 0.20);
            ingredientArr[9] = Tomatoes;
            Ingredient Lettuce = new Ingredient("Lettuce", 0.20);
            ingredientArr[10] = Lettuce;



            //MessageBox.Show(test.name);
        }

        private void richTextBox_output_TextChanged(object sender, EventArgs e)
        {

        }

        //Entrees

        //Chick-fil-A Chicken Sandwitch
        private void button1_Click(object sender, EventArgs e)
        {
            Ingredient[] Chick_fil_A_Chicken_Sandwich_Ingredients = new Ingredient[3];
            Ingredient Regular_Bun = new Ingredient("Regular Bun", 0.30);
            Ingredient FriedChicken_Patty = new Ingredient("Fried Chicken Patty", 0.30);
            Ingredient Pickles = new Ingredient("Pickles", 0.15);
            Chick_fil_A_Chicken_Sandwich_Ingredients[0] = Regular_Bun;
            Chick_fil_A_Chicken_Sandwich_Ingredients[1] = FriedChicken_Patty;
            Chick_fil_A_Chicken_Sandwich_Ingredients[2] = Pickles;

            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Chick-fil-A Chicken Sandwich - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Chick-fil-A Deluxe Sandwitch
        private void button2_Click(object sender, EventArgs e)
        {
            Ingredient[] Chick_fil_A_Deluxe_Sandwitch_Ingredients = new Ingredient[5];
            Ingredient Regular_Bun = new Ingredient("Regular Bun", 0.30);
            Ingredient Chedder_Cheese = new Ingredient("Chedder Cheese", 0.30);
            Ingredient FriedChicken_Patty = new Ingredient("Fried Chicken Patty", 0.30);
            Ingredient Tomatoes = new Ingredient("Tomatoes", 0.20);
            Ingredient Lettuce = new Ingredient("Lettuce", 0.20);
            Chick_fil_A_Deluxe_Sandwitch_Ingredients[0] = Regular_Bun;
            Chick_fil_A_Deluxe_Sandwitch_Ingredients[1] = Chedder_Cheese;
            Chick_fil_A_Deluxe_Sandwitch_Ingredients[2] = FriedChicken_Patty;
            Chick_fil_A_Deluxe_Sandwitch_Ingredients[3] = Tomatoes;
            Chick_fil_A_Deluxe_Sandwitch_Ingredients[4] = Lettuce;

            Amount = 3.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Chick-fil-A Deluxe Sandwich - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Spicy Chicken Sandwitch
        private void button3_Click(object sender, EventArgs e)
        {
            Ingredient[] Spicy_Chicken_Sandwitch_Ingredients = new Ingredient[3];
            Ingredient Regular_Bun = new Ingredient("Regular Bun", 0.30);
            Ingredient FriedChicken_Patty = new Ingredient("Fried Chicken Patty", 0.30);
            Ingredient Pickles = new Ingredient("Pickles", 0.15);
            Spicy_Chicken_Sandwitch_Ingredients[0] = Regular_Bun;
            Spicy_Chicken_Sandwitch_Ingredients[1] = FriedChicken_Patty;
            Spicy_Chicken_Sandwitch_Ingredients[2] = Pickles;

            Amount = 3.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox  = OrderBox + "\n" + " " + quanitity + " Spicy Chicken Sandwich - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Spicy Deluxe Sandwitch
        private void button4_Click(object sender, EventArgs e)
        {
            Ingredient[] Spicy_Deluxe_Sandwich_Ingredients = new Ingredient[5];
            Ingredient Regular_Bun = new Ingredient("Regular_Bun", 0.30);
            Ingredient Pepper_Jack_Cheese = new Ingredient("Pepper Jack Cheese", 0.30);
            Ingredient FriedChicken_Patty = new Ingredient("Fried Chicken Patty", 0.30);
            Ingredient Tomatoes = new Ingredient("Tomatoes", 0.20);
            Ingredient Lettuce = new Ingredient("Lettuce", 0.20);
            Spicy_Deluxe_Sandwich_Ingredients[0] = Regular_Bun;
            Spicy_Deluxe_Sandwich_Ingredients[1] = Pepper_Jack_Cheese;
            Spicy_Deluxe_Sandwich_Ingredients[2] = FriedChicken_Patty;
            Spicy_Deluxe_Sandwich_Ingredients[3] = Tomatoes;
            Spicy_Deluxe_Sandwich_Ingredients[4] = Lettuce;
            


            Amount = 3.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox  = OrderBox + "\n" + " " + quanitity + " Spicy Deluxe Sandwich - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Grilled Chicken Sandwitch
        private void button5_Click(object sender, EventArgs e)
        {
            Ingredient[] Grilled_Chicken_Sandwitch_Ingredients = new Ingredient[4];
            Ingredient Regular_Bun = new Ingredient("Regular_Bun", 0.30);
            Ingredient Grilled_Chicken_Patty = new Ingredient("Grilled Chicken Patty", 0.40);
            Ingredient Tomatoes = new Ingredient("Tomatoes", 0.20);
            Ingredient Lettuce = new Ingredient("Pickles", 0.20);
            Grilled_Chicken_Sandwitch_Ingredients[0] = Regular_Bun;
            Grilled_Chicken_Sandwitch_Ingredients[1] = Grilled_Chicken_Patty;
            Grilled_Chicken_Sandwitch_Ingredients[2] = Tomatoes;
            Grilled_Chicken_Sandwitch_Ingredients[3] = Lettuce;

            Amount = 3.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Grilled Chicken Sandwich - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Chick-fil-A Grilled Chicken Club Sandwitch
        private void button6_Click(object sender, EventArgs e)
        {
            Ingredient[] Chick_fil_A_Grilled_Chicken_Club_Sandwich_Ingredients = new Ingredient[6];
            Ingredient Whole_Wheat_Bun = new Ingredient("Whole Wheat Bun", 0.20);
            Ingredient Bacon = new Ingredient("Bacon", 0.10);
            Ingredient Coby_Jack_Cheese = new Ingredient("Coby_Jack_Cheese", 0.30);
            Ingredient Grilled_Chicken_Patty = new Ingredient("Grilled Chicken Patty", 0.40);
            Ingredient Tomatoes = new Ingredient("Tomatoes", 0.20);
            Ingredient Lettuce = new Ingredient("Lettuce", 0.20);
            Chick_fil_A_Grilled_Chicken_Club_Sandwich_Ingredients[0] = Whole_Wheat_Bun;
            Chick_fil_A_Grilled_Chicken_Club_Sandwich_Ingredients[1] = Bacon;
            Chick_fil_A_Grilled_Chicken_Club_Sandwich_Ingredients[2] = Coby_Jack_Cheese;
            Chick_fil_A_Grilled_Chicken_Club_Sandwich_Ingredients[3] = Grilled_Chicken_Patty;
            Chick_fil_A_Grilled_Chicken_Club_Sandwich_Ingredients[4] = Tomatoes;
            Chick_fil_A_Grilled_Chicken_Club_Sandwich_Ingredients[5] = Lettuce;

            Amount = 3.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Chick fil-A Grilled Chicken Club Sandwich - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Grilled Spicy Deluxe
        private void button7_Click(object sender, EventArgs e)
        {
            Ingredient[] Grilled_Spicy_Deluxe_Ingredients = new Ingredient[5];
            Ingredient Whole_Wheat_Bun = new Ingredient("Whole Wheat Bun", 0.20);
            Ingredient Coby_Jack_Cheese = new Ingredient("Coby Jack Cheese", 0.30);
            Ingredient FriedChicken_Patty = new Ingredient("Fried Chicken Patty", 0.30);
            Ingredient Tomatoes = new Ingredient("Tomatoes", 0.20);
            Ingredient Lettuce = new Ingredient("Lettuce", 0.20);
            Grilled_Spicy_Deluxe_Ingredients[0] = Whole_Wheat_Bun;
            Grilled_Spicy_Deluxe_Ingredients[1] = Coby_Jack_Cheese;
            Grilled_Spicy_Deluxe_Ingredients[2] = FriedChicken_Patty;
            Grilled_Spicy_Deluxe_Ingredients[3] = Tomatoes;
            Grilled_Spicy_Deluxe_Ingredients[4] = Lettuce;

            Amount = 3.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Grilled Spicy Deluxe - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Chick-fil-A Nuggets
        private void button8_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Chick-fil-A Nuggets - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Grilled Nuggets
        private void button9_Click(object sender, EventArgs e)
        {
            Amount = 3.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Grilled Nuggets - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Sides

        //Chick-fil-A Waffle Potato Fries
        private void button19_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Chick-fil-A Waffle Potato Fries - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Fruit Cup
        private void button20_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Fruit Cup - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Side Salad
        private void button21_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Side Salad - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Mac and Cheese
        private void button22_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Mac and Cheese - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Chicken Noodle Soup
        private void button23_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Chicken Noodle Soup - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Chicken Tortilla Soup
        private void button24_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Chicken Tortilla Soup - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Kale Crunch Side
        private void button25_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Kale Crunch Side - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Greek Yogurt Parfait
        private void button26_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Greek Yogurt Parfait - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
        }

        //Waffle Potato Chips
        private void button27_Click(object sender, EventArgs e)
        {
            Amount = 1.00;
            tempPrice = quanitity * Amount;
            total = total + tempPrice;
            OrderBox = OrderBox + "\n" + " " + quanitity + " Waffle Potato Chips - $" + tempPrice;
            this.richTextBox_output.Text = OrderBox;
            this.total_label.Text = "Total: $" + total;
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


        //Amount Buttons
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

        private void total_label_Click(object sender, EventArgs e)
        {
            
        }

        private void button_qtyCustom_Click_1(object sender, EventArgs e)
        {

        }

        private void button_largeDrink_Click(object sender, EventArgs e)
        {

        }
        private void button_amtTender_Click(object sender, EventArgs e)
        {
            amt_Form();
        }
        public void amt_Form()
        {
            AmountTender amtTender = new AmountTender();
            amtTender.ShowDialog();
        }

        private void button_modifyExisting_Click(object sender, EventArgs e)
        {
            Form_editAnItem aForm = new Form_editAnItem();
            aForm.ShowDialog();
        }
    }
}     

