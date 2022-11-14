

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

        private string namaLengkap;
        private int umur;

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

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (tbConfPass.Text != tbNewPass.Text || tbFullName.Text=="" || tbAge.Text=="" || tbNewUsername.Text=="")
            {
                if (tbFullName.Text == "")
                {
                    MessageBox.Show("Nama lengkap tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tbNewUsername.Text == "")
                {
                    MessageBox.Show("Username tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tbNewPass.Text == "")
                {
                    MessageBox.Show("Password harus diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbConfPass.Text != tbNewPass.Text)
                {
                    MessageBox.Show("Password tidak sama!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblNotMatch.Visible = true;
                    return;
                }

                if (tbAge.Text == "")
                {
                    MessageBox.Show("Umur tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            try
            {
                NpgsqlConnection.Open();
                _username = tbNewUsername.Text;
                _password = tbNewPass.Text;
                namaLengkap = tbFullName.Text;
                umur = Int32.Parse(tbAge.Text);

                sql = @"select * from registration(:_username, :_password, :_name, :_age)";
                cmd = new NpgsqlCommand(sql, NpgsqlConnection);
                cmd.Parameters.AddWithValue("_username", _username);
                cmd.Parameters.AddWithValue("_password", _password);
                cmd.Parameters.AddWithValue("_name", namaLengkap);
                cmd.Parameters.AddWithValue("_age", umur);



                if ((int)cmd.ExecuteScalar() ==1)
                {
                    loginPanel.BringToFront();
                    MessageBox.Show("Registrasi berhasil! silahkan login ke menu awal.", "Registrasi Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informasi yang anda masukkan salah !", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                NpgsqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registrasi gagal!\n" + ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}