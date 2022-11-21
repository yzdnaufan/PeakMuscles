using Npgsql;

namespace WorkoutTrainer
{
    public partial class main : Form
    {
        private string? bgState;
        private string _username;

        private List<Muscle> muscles = new List<Muscle>();
        private Muscle muscle = new Muscle();

        private NpgsqlCommand cmd;
        private int i=0;

        private NpgsqlConnection NpgsqlConnection;
        string connstr = "Host=juniorproject-peakmuscle.postgres.database.azure.com; Port=5432; Username=peakmuscle; Password=YazidTinaNovaldy2022; Database=junpro";

        public main(string username)
        {
            this._username = username;
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

        private List<Muscle> load_data(string s)
        {
            List<Muscle> m = new List<Muscle>();
            try
            {

                NpgsqlConnection.Open();
                string sql = $"select * from public.\"tb{s}\"";       //change to npgsql function for each muscle
                cmd = new NpgsqlCommand(sql, NpgsqlConnection);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    m.Add(new Muscle { 
                        _name = dr["nama"].ToString(), 
                        _url = dr["url"].ToString(), 
                        id= Convert.ToInt32(dr["id"]) });
                }
                NpgsqlConnection.Close();
                return m;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void Default_load_data(string s="Abs")
        {   
            muscles = load_data(s);
            lblNamaGerakan.Text = muscles[i]._name;
            pbGerakan.ImageLocation = muscles[i]._url;
        }

        private void main_Load(object sender, EventArgs e)
        {
            NpgsqlConnection = new NpgsqlConnection(connstr);
            label1.Text = this.Text;
            Default_load_data();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //abs
        private void button1_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgState = this.button1.Text.ToString();
                Default_load_data(bgState);
                label1.Text = bgState;
            }
        }

        //pushup
        private void button2_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgState = this.button2.Text.ToString();
                Default_load_data(bgState);
                label1.Text = bgState;
            }
        }

        //squats
        private void button3_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgState = this.button3.Text.ToString();
                Default_load_data(bgState);
                label1.Text = bgState;
            }
        }

        //triceps
        private void button4_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgState = this.button4.Text.ToString();
                Default_load_data(bgState);
                label1.Text = bgState;
            }
        }

        //biceps
        private void button5_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgState = this.button5.Text.ToString();
                Default_load_data(bgState);
                label1.Text = bgState;
            }
        }

        //shoulder
        private void button6_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgState = this.button6.Text.ToString();
                Default_load_data(bgState);
                label1.Text = bgState;
            }
        }

        //back
        private void button7_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgState = this.button7.Text.ToString();
                Default_load_data(bgState);
                label1.Text = bgState;
            }
        }


        //glutes
        private void button8_Click(object sender, EventArgs e)
        {
            if (bgState != this.Text.ToString())
            {
                bgState = this.button8.Text.ToString();
                Default_load_data(bgState);
                label1.Text = bgState;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i+1 >= muscles.Count)
            {
                i = 0;
                pbGerakan.ImageLocation = muscles[i]._url;
                lblNamaGerakan.Text = muscles[i]._name;
            }
            else
            {
                i++;
                pbGerakan.ImageLocation = muscles[i]._url;
                lblNamaGerakan.Text = muscles[i]._name;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (i - 1 <0)
            {
                i = muscles.Count-1;

                pbGerakan.ImageLocation = muscles[i]._url;
                lblNamaGerakan.Text = muscles[i]._name;
            }
            else
            {
                i--;
                pbGerakan.ImageLocation = muscles[i]._url;
                lblNamaGerakan.Text = muscles[i]._name;
            }
        }
    }
}