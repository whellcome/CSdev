using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;        
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Hide();
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
            for (int i = 0; i < 3; i++)
            {
                this.label1.Text = "_";
                this.Refresh();
                System.Threading.Thread.Sleep(500);
                this.label1.Text = "";
                this.Refresh();
                System.Threading.Thread.Sleep(500);
            };
            DisplayHi(this, this.label1, "Wake up, Neo...");
            DisplayHi(this, this.label1, "The Matrix has you...");
            DisplayHi(this, this.label1, "Follow the white rabbit.");
            DisplayHi(this, this.label1, "Knock, knock, Neo.");
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
            this.Close();
        }
        private static void DisplayHi(Form form, Label label, string hi)
        {
            for (int i = 0; i < 1; i++)
            {
                label.Text = "_";
                form.Refresh();
                System.Threading.Thread.Sleep(250);
                label.Text = "";
                form.Refresh();
            };
            char[] hiChar = hi.ToCharArray();
            foreach (char ch in hiChar)
            {
                label.Text += ch+"_";
                form.Refresh();
                System.Threading.Thread.Sleep(150);
                label.Text = label.Text.Remove(label.Text.Length - 1);
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
