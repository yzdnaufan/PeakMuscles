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
    public partial class HomePage : Form
    {
        private string username;
        public HomePage(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
