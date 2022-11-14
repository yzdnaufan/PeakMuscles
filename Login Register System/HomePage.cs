﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Login_Register_System
{
    public partial class HomePageForm : Form
    {
        private string username;
        private string password;
        public HomePageForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void HomePageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCalorieIntake_Click(object sender, EventArgs e)
        {
            CalorieIntake.mainCal maincal = new CalorieIntake.mainCal();
            this.Hide();
            maincal.Show();
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            WorkoutTrainer.main main = new WorkoutTrainer.main();
            this.Hide();
            main.Show();
        }
    }
}
