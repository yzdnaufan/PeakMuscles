using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieIntake;
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
            mainCal mainCal = new mainCal(username);
            this.Hide();
            mainCal.Show();
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            WorkoutTrainer.main main = new WorkoutTrainer.main(username);
            this.Hide();
            main.Show();
        }
    }
}
