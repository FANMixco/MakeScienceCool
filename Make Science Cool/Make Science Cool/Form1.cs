using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Science_Cool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Videos AFormInstance = new Videos();
            AFormInstance.Text = "Computer Anatomy";
            AFormInstance.Option = "Computer Anatomy";
            AFormInstance.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Videos AFormInstance = new Videos();
            AFormInstance.Text = "Nervous System";
            AFormInstance.Option = "Nervous System";
            AFormInstance.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Videos AFormInstance = new Videos();
            AFormInstance.Text = "Electronic Parts";
            AFormInstance.Option = "Electronic Parts";
            AFormInstance.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string path = "MyHangman2.jar";
            Process process = new Process();
            process.EnableRaisingEvents = false;
            process.StartInfo.FileName = Environment.GetEnvironmentVariable("JAVA_HOME") + "\\bin\\java.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.Arguments = "-jar " + '"' + path;

            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            About AFormInstance = new About();
            AFormInstance.Show();
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Image.FromFile("Images/Button1_over.png");
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile("Images/Button1.png");
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Image.FromFile("Images/Button2_over.png");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("Images/Button2.png");
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Image.FromFile("Images/Button3_over.png");
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile("Images/Button3.png");
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.Image = Image.FromFile("Images/Button4_over.png");
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile("Images/Button4.png");
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Image.FromFile("Images/Button1_click.png");
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Image.FromFile("Images/Button2_click.png");
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Image.FromFile("Images/Button3_click.png");
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.Image = Image.FromFile("Images/Button4_click.png");
        }
    }
}
