using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 屏保
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int deltx = 5;
        int delty = 4;
        int timex = 4;
        int timey = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.label_win.Left += deltx;
            this.label_win.Top += delty;
            this.label_win.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            if (this.label_win.Top < 0 ||
                this.label_win.Top + this.label_win.Height > this.Height)
                delty = -delty;
            if (this.label_win.Left < 0 ||
                this.label_win.Left + this.label_win.Width > this.Width)
                deltx = -deltx;
            this.label_time.Text = DateTime.Now.ToString();
            //this.label_time.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            this.label_time.Left -= timex;
            this.label_time.Top -= timey;
            if (this.label_time.Top < 0 ||
                this.label_time.Top + this.label_time.Height > this.Height)
                timey = -timey;
            if (this.label_time.Left < 0 ||
                this.label_time.Left + this.label_time.Width > this.Width)
                timex = -timex;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
