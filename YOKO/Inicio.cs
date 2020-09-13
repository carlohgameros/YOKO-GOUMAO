using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YOKO.Helpers;
using YOKO.Notifications;

namespace YOKO
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {   
            if (SettingsHelper.getInstance().ShouldShowDolar())
            {
                NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "Precio del dolar", new ExchangePrice().GetDolarPrice().ToString(), ToolTipIcon.Info);
            }
        }

        private void Label3_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new Venta());

        private void label4_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new Productos());

        private void label6_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new Tickets());

        private void label5_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new NuevoUsuario());

        private void label8_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new AltasSecundarias());

        private void label9_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new DatosFiscales());

        private void label7_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new Configuraciones());

        private void navigationBar1_Load(object sender, EventArgs e)
        {
            navigationBar1.BackColor = Color.FromArgb(1, 55, 55, 55);
            navigationBar1.HideBackButton();
            navigationBar1.HideTitle();
            navigationBar1.ChangeBackgroundColor(Color.FromName("White"));
            navigationBar1.StopAllApp();
        }


        private void SetHoverStyle(Label label)
        {
            //label.Font = new Font(label.Font.Name, 32, FontStyle.Bold);
        } 

        private void SetNormalStyle(Label label)
        {
            //label.Font = new Font(label.Font.Name, 28, FontStyle.Regular);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            SetNormalStyle(label3);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            SetHoverStyle(label3);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            SetNormalStyle(label4);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            SetHoverStyle(label4);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            SetNormalStyle(label5);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            SetHoverStyle(label5);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            SetNormalStyle(label6);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            SetHoverStyle(label6);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            SetNormalStyle(label7);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            SetHoverStyle(label7);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            SetNormalStyle(label8);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            SetHoverStyle(label8);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            SetNormalStyle(label9);
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            SetHoverStyle(label9);
        }
    }
}
