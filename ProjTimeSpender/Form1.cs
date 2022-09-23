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
    public partial class frmMainStationDahe : Form
    {
        int Time = 0;
        List<Workaction> work = new List<Workaction>();
        public frmMainStationDahe()
        {
            InitializeComponent();
            /*
             * look into notfiyicons tool for icon in right botom min
             * 
             *
            */
            
        }

        private void btnStartWorkDahe_Click(object sender, EventArgs e)
        {
            Console.Write("button pressed");

            Workaction NewWork = new Workaction(txbCustomWorkDahe.Text);
        }

        private void HideIconDahe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            niyShowIconDahe.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void frmMainStationDahe_Load(object sender, EventArgs e)
        {
            tmrScreenDiscoDahe.Start();
            niyShowIconDahe.BalloonTipText = "app min";
            niyShowIconDahe.BalloonTipTitle = "test app";
        }

        private void frmMainStationDahe_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                niyShowIconDahe.Visible = true;
                niyShowIconDahe.ShowBalloonTip(1000);
            }
        }
        
        private void tmrScreenDiscoDahe_Tick(object sender, EventArgs e)
        {
            if (Time % 2 == 0)
            {
                BackColor = Color.Red;
                Time++;
            }
            else
            {
                BackColor = Color.White;
                Time++;
            }
        }
        class Workaction
        {
            public String Workname;

            public Workaction(String name)
            {
                Workname = name;
            }

        }

        
    }
}
