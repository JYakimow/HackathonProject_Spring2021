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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test

        }

        private void button_mgr_Click(object sender, EventArgs e)
        {
            mgr_Form();
        }

        public void mgr_Form()
        {
            ManagerMenu mgrMenu = new ManagerMenu();
            mgrMenu.Show();
            
        }
    }
}
