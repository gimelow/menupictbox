using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuimg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Width = 50;
            pictureBox1.Height = 50;
            label1.Text = "calculadora";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Width = 45;
            pictureBox1.Height = 45;
            pictureBox2.Width = 45;
            pictureBox2.Height = 45;
            pictureBox3.Width = 45;
            pictureBox3.Height = 45;
            pictureBox4.Width = 45;
            pictureBox4.Height = 45;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Width = 55;
            pictureBox3.Height = 55;
            label3.Text = "bloco de notas";
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Width = 55;
            pictureBox2.Height = 55;
            label2.Text = "google chrome";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja sair?", "confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Width = 50;
            pictureBox4.Height = 50;
            label4.Text = "sair";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
