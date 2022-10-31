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
            person.Username = tbUsernameLogin.Text;
            person.Password = tbPasswordLogin.Text;
            if (person.Login(person.Username, person.Password))
            {
                this.Hide();
                HomePageForm homepage = new HomePageForm(" ");
                homepage.Show();
            }
            else
            {
                MessageBox.Show("Login Failed! Invalid Username or Password");
            }
        }
    }
}