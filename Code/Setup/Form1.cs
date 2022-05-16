using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Setup
{
    public partial class Form1 : Form
    {

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        public Form1()
        {
            InitializeComponent();
            Text.SendToBack();
            Text2.SendToBack();
            Text3.SendToBack();
            Text4.SendToBack();
            Text5.SendToBack();
            Text6.SendToBack();
            Text7.SendToBack();
            Text8.SendToBack();
            Bottomtext.SendToBack();
            Bottomtext2.SendToBack();
            Bottomtext3.SendToBack();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod.BringToFront();
            Bsod.Dock = DockStyle.Fill;

        }

        private void Bsod_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod.BringToFront();
            Bsod.Dock = DockStyle.Fill;
            Text.BringToFront();
            Bottomtext.BringToFront();
            Bottomtext2.BringToFront();
            Bottomtext3.BringToFront();

        }

        private void Orange_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod2.BringToFront();
            Bsod2.Dock = DockStyle.Fill;
            Text2.BringToFront();
            Bottomtext.BringToFront();
            Bottomtext.BackColor = Color.Orange;
            Bottomtext2.BringToFront();
            Bottomtext2.BackColor = Color.Orange;
            Bottomtext3.BringToFront();
            Bottomtext3.BackColor = Color.Orange;

        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod3.BringToFront();
            Bsod3.Dock = DockStyle.Fill;
            Text3.BringToFront();
            Bottomtext.BringToFront();
            Bottomtext.BackColor = Color.Yellow;
            Bottomtext2.BringToFront();
            Bottomtext2.BackColor = Color.Yellow;
            Bottomtext3.BringToFront();
            Bottomtext3.BackColor = Color.Yellow;

        }

        private void Green_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod4.BringToFront();
            Bsod4.Dock = DockStyle.Fill;
            Text4.BringToFront();
            Bottomtext.BringToFront();
            Bottomtext.BackColor = Color.ForestGreen;
            Bottomtext2.BringToFront();
            Bottomtext2.BackColor = Color.ForestGreen;
            Bottomtext3.BringToFront();
            Bottomtext3.BackColor = Color.ForestGreen;

        }

        private void Blue_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod5.BringToFront();
            Bsod5.Dock = DockStyle.Fill;
            Text5.Hide();
            Bottomtext.Hide();

            Bottomtext2.Hide();

            Bottomtext3.Hide();

        }

        private void Purple_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod6.BringToFront();
            Bsod6.Dock = DockStyle.Fill;
            Text6.BringToFront();
            Bottomtext.BringToFront();
            Bottomtext.BackColor = Color.Purple;
            Bottomtext2.BringToFront();
            Bottomtext2.BackColor = Color.Purple;
            Bottomtext3.BringToFront();
            Bottomtext3.BackColor = Color.Purple;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Text2_Click(object sender, EventArgs e)
        {

        }

        private void Bottomtext_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Black_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod7.BringToFront();
            Bsod7.Dock = DockStyle.Fill;
            Text7.BringToFront();
            Bottomtext.BringToFront();
            Bottomtext.BackColor = Color.Black;
            Bottomtext2.BringToFront();
            Bottomtext2.BackColor = Color.Black;
            Bottomtext3.BringToFront();
            Bottomtext3.BackColor = Color.Black;
        }

        private void White_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Bsod8.BringToFront();
            Bsod8.Dock = DockStyle.Fill;
            Text8.BringToFront();
            Bottomtext.BringToFront();
            Bottomtext.BackColor = Color.White;
            Bottomtext.ForeColor = Color.Black;
            Bottomtext2.BringToFront();
            Bottomtext2.BackColor = Color.White;
            Bottomtext2.ForeColor = Color.Black;
            Bottomtext3.BringToFront();
            Bottomtext3.BackColor = Color.White;
            Bottomtext3.ForeColor = Color.Black;
        }

        private void Text7_Click(object sender, EventArgs e)
        {

        }

        private void Bsod8_Click(object sender, EventArgs e)
        {

        }
    }
}
