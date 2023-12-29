using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace gmod_launcher
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            String Valor = "http://reccpe.com.tr"; // YOUR DISCORD URL ADRESS

            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = Valor,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            String URI = "https://github.com/Reccpe"; // Your youtube channel
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = URI,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            String ServerURI = "https://mtasa://185.71.66.80:22003"; // YOUR SERVER Adress 
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = ServerURI,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
