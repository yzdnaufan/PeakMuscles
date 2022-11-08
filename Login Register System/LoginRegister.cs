

using Npgsql;
using System.Security.Cryptography;

namespace Login_Register_System
{
    public partial class LoginRegister : Form
    {
        protected string _username;
        private string _password;
        protected string _id;
        private string sql = null;
        public static NpgsqlCommand cmd;

        private NpgsqlConnection NpgsqlConnection;
        string connstr = "Host=juniorproject-peakmuscle.postgres.database.azure.com; Port=5432; Username=peakmuscle; Password=YazidTinaNovaldy2022; Database=junpro";

        public LoginRegister()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsernameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            loginPanel.BringToFront();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            registerPanel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection.Open();
                _username = tbUsernameLogin.Text;
                _password = tbPasswordLogin.Text;
                sql = @"select * from loginuser(:_username, :_password)";
                cmd = new NpgsqlCommand(sql, NpgsqlConnection);
                cmd.Parameters.AddWithValue("_username", _username);
                cmd.Parameters.AddWithValue("_password", _password);

                if ((string)cmd.ExecuteScalar() != "0")
                {
                    this.Hide();
                    MessageBox.Show("Login berhasil! selamat datang " + cmd.ExecuteScalar().ToString(), "Login Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomePageForm homepage = new HomePageForm(" ");
                    homepage.Show();
                }
                else
                {
                    MessageBox.Show("Informasi yang anda masukkan salah !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                NpgsqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !"+ ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginRegister_Load(object sender, EventArgs e)
        {
            NpgsqlConnection = new NpgsqlConnection(connstr);
        }
    }
}