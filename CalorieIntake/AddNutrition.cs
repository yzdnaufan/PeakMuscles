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
using Npgsql;

namespace CalorieIntake
{
    public partial class AddNutrition : Form
    {
        private NpgsqlConnection conn;
        string constr = "Host=juniorproject-peakmuscle.postgres.database.azure.com; Port=5432; Username=peakmuscle; Password=YazidTinaNovaldy2022; Database=junpro";

        public DataTable dt;
        public int input;
        public static NpgsqlCommand cmd;
        private DataGridViewRow r;
        private int addCal;
        private int deleteCal;
        public AddNutrition()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(constr);
            cmd = new NpgsqlCommand(constr);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_types order by foodid ASC";
            NpgsqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rd);
                dgvFood.DataSource = dt;
            }
            conn.Close();
        }

        private void AddNutrition_Load(object sender, EventArgs e)
        {
            lblCalOut.Text = mainCal.setCal;
            pbCalorie.Maximum = mainCal.numberCal;
            pbCalorie.Minimum = 0;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            pbCalorie.Step = addCal;
            pbCalorie.PerformStep();
            if (r == null)
            {
                MessageBox.Show("Mohon pilih makanan yang sudah anda makan", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (pbCalorie.Value == pbCalorie.Maximum)
            {
                MessageBox.Show("Selamat! Kalori harian anda telah terpenhuhi");
            }
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvFood.Rows[e.RowIndex];
                lblCalStart.Text = r.Cells["jumlah_kalori"].Value.ToString();
                addCal = Convert.ToInt32(r.Cells["jumlah_kalori"].Value);
            }
        }

        private void btnResetFood_Click(object sender, EventArgs e)
        {
            pbCalorie.Step = deleteCal;
            pbCalorie.PerformStep();
            if (pbCalorie.Value > pbCalorie.Minimum)
            {
                pbCalorie.Value = 0;
                btnResetFood.Enabled = true;
            }
        }

        private void pictboxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
