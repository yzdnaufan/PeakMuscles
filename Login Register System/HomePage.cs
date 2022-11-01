using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register_System
{
    public partial class HomePageForm : Form
    {
        private string username;
        public HomePageForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkoutTrainer.main main = new WorkoutTrainer.main();
            this.Hide();
            main.Show();
        }

        private void HomePageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
