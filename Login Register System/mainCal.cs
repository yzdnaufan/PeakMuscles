using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register_System
{
    public partial class mainCal : Form
    {
        public static string? setCal;
        public static int numberCal;
        string txt = "Enter the target amount of calories";
        public mainCal()
        {
            InitializeComponent();
        }

        private void tbCalorieInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCalorieInput_Enter(object sender, EventArgs e)
        {
            if (tbCalorieInput.Text == txt)
            {
                tbCalorieInput.Text = "";
                tbCalorieInput.ForeColor = Color.Black;
            }
        }

        private void tbCalorieInput_Leave(object sender, EventArgs e)
        {
            if (tbCalorieInput.Text == "")
            {
                tbCalorieInput.Text = txt;
                tbCalorieInput.ForeColor = Color.Silver;
            }
        }

        private void btnCalorieInput_Click(object sender, EventArgs e)
        {
            setCal = tbCalorieInput.Text + " Calories";
            numberCal = Convert.ToInt32(tbCalorieInput.Text);
            AddNutrition addNutrition = new AddNutrition();
            if (tbCalorieInput.Text != txt)
            {
                this.Hide();
                addNutrition.Show();
            }
            else if (tbCalorieInput.Text == txt)
            {
                MessageBox.Show("Tolong masukkan jumlah kebutuhan kalori anda", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void pictboxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}