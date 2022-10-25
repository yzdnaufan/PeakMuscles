namespace Login_Register_System
{
    public partial class LoginRegister : Form
    {
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
            Person person = new Person();
            person.Username = txtUsernameLogin.Text;
            person.Password = txtPasswordLogin.Text;
            if (person.Login(person.Username, person.Password))
            {
                MessageBox.Show("Login Success");
            }
            else
            {
                MessageBox.Show("Login Failed! Who Are You?");
            }
        }
    }
}