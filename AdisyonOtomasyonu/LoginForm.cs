using AdisyonOtomasyonu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdisyonOtomasyonu
{
    public partial class LoginForm : Form
    {
        public int check = 1;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;    
            MinimizeBox = false;
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                pictureBox3.Image = Resources.open_padlock;
                textBox2.UseSystemPasswordChar = false;
                check = 0;
            }
            else if (check == 0) 
            {
                pictureBox3.Image = Resources.padlock;
                textBox2.UseSystemPasswordChar = true;
                check = 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.ShowDialog();
            LoginForm form2 = new LoginForm();
            form2.Hide();
        }
    }
}
