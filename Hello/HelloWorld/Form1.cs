using System;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            
            DisplayHi(this, this.label1, "Wake up, Neo...");
            DisplayHi(this, this.label1, "The Matrix has you...");
            DisplayHi(this, this.label1, "Follow the white rabbit.");
            DisplayHi(this, this.label1, "Knock, knock, Neo.");

            this.Close();
            
        }
        internal static void DisplayHi(Form form, Label label, string hi)
        {
            label.Text = "";
            form.Refresh();

            for (int i = 0; i < 1; i++)
            {
                label.Text += "_";
                form.Refresh();
                System.Threading.Thread.Sleep(250);
                label.Text = label.Text.Remove(label.Text.Length - 1);
                form.Refresh();
            };
            char[] hiChar = hi.ToCharArray();
            foreach (char ch in hiChar)
            {
                label.Text += ch;
                form.Refresh();
                System.Threading.Thread.Sleep(150);
            }
            for (int i = 0; i < 4; i++)
            {
                label.Text += "_";
                form.Refresh();
                System.Threading.Thread.Sleep(500);
                label.Text = label.Text.Remove(label.Text.Length - 1);
                form.Refresh();
                System.Threading.Thread.Sleep(500);
            };
        }
    }
}
