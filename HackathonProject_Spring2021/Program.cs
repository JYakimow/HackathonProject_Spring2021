﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonProject_Spring2021
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
    /*
    public class ingredient
    {
        String[] ingredients = { "" };
        int count = 0;
        static void addIngredient(string i)
        {
            ingredient newingredient = new ingredient();
            ingredients[count] = newingredient;
        }
    }
    */

}
