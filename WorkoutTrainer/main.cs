namespace WorkoutTrainer
{
    public partial class main : Form
    {
        private string bgState;

        public main()
        {
            InitializeComponent();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            label1.Text = this.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //abs
        private void button1_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgPict.Load("https://seven.app/media/images/Crunches.gif");
                bgState = this.button1.Text.ToString();
            }
        }

        //pushup
        private void button2_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgPict.Load("https://media.tenor.com/gI-8qCUEko8AAAAM/pushup.gif");
                bgState = this.button2.Text.ToString();
            }
        }

        //squats
        private void button3_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgPict.Load("https://seven.app/media/images/image4.gif");
                bgState = this.button3.Text.ToString();
            }
        }

        //triceps
        private void button4_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgPict.Load("https://images.everydayhealth.com/images/6-top-triceps-tricep-dip.gif");
                bgState = this.button4.Text.ToString();
            }
        }

        //biceps
        private void button5_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgPict.Load("https://images.everydayhealth.com/images/best-exercises-for-stronger-arm-muscles-wide-curl.gif");
                bgState = this.button5.Text.ToString();
            }
        }

        //shoulder
        private void button6_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgPict.Load("https://cdn.shopify.com/s/files/1/1501/0558/files/Lateral_Shoulder_Raises.gif?v=1506073016");
                bgState = this.button6.Text.ToString();
            }
        }

        //back
        private void button7_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgPict.Load("https://miro.medium.com/max/960/1*R7JxVbE2uc18G37natvTgw.gif");
                bgState = this.button7.Text.ToString();
            }
        }


        //glutes
        private void button8_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgPict.Load("https://www.ammfitness.co.uk/information-advice/wp-content/uploads/2020/04/Glute-Bridge.gif");
                bgState = this.button8.Text.ToString();
            }
        }
    }
}