using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjTimeSpender
{
    public partial class Form1 : Form
    {
        bool tick = true;
        public Form1()
        {
            InitializeComponent();
            /*
             * look into notfiyicons tool for icon in right botom min
             * 
             *
            */
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button pressed");

        }

        private void HideIconDahe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            HideIconDahe.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            HideIconDahe.BalloonTipText = "app min";
            HideIconDahe.BalloonTipTitle = "test app";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                HideIconDahe.Visible = true;
                HideIconDahe.ShowBalloonTip(1000);
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            BackColor = Color.White;
            tick = false;
            if (tick == false)
            {
                Console.WriteLine("test");
                BackColor = Color.Red;
                tick = true;
            }
        }
        void colorChange()
        {

        }
    }
}
