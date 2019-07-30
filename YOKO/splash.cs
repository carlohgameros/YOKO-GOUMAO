using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOKO
{
    public partial class splash : Form
    {

        Timer t1 = new Timer();

        public splash()
        {
            InitializeComponent();
            Notifications.NotificationsCenter notificationsCenter = new Notifications.NotificationsCenter(YOKKO);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();
                System.Threading.Thread.Sleep(5000);
                Close();
            }
            else
            {
                Opacity += 0.05;
            }
                
            
        }

        private void splash_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
        }

        private void splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            t1.Tick += new EventHandler(fadeOut);
            t1.Start();

            if (Opacity == 0) { 
                e.Cancel = false;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                t1.Stop();
                ClosingProcess();
                Hide();
            }
            else
                Opacity -= 0.05;
        }

        private void splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ClosingProcess()
        {
            Login login = new Login();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
