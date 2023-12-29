namespace gmod_launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MainMenu menuMain = new MainMenu();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = string.Empty;
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value += 2;
                label1.Text = guna2ProgressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                menuMain.Show();

            }
        }
    }
}