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

namespace YOKO
{
    public partial class Configuraciones : Form
    {
        private float iva = 16.00F;
        private float dolar = 0.50F;

        private SettingsHelper settingsHelper;

        public Configuraciones()
        {
            InitializeComponent();
        }

        private void getInitialData()
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            float precio;
            var aplica = float.TryParse(ivaField.Text, out precio);
            ivaField.Text = (precio + this.iva).ToString() + ".00";
            if ((precio - 10) >= 0)
            {
                ivaField.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        private void ivaDownButton_Click(object sender, EventArgs e)
        {
            float precio;
            var aplica = float.TryParse(ivaField.Text, out precio);
            ivaField.Text = (precio - this.iva).ToString() + ".00";
            if ((precio - 10) >= 0)
            {
                ivaField.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        private void dolarUpButton_Click(object sender, EventArgs e)
        {
            float precio;
            var aplica = float.TryParse(dolarField.Text, out precio);
            dolarField.Text = (precio + this.dolar).ToString() + ".00";
            if ((precio - 10) >= 0)
            {
                dolarField.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        private void dolarDownButton_Click(object sender, EventArgs e)
        {
            float precio;
            var aplica = float.TryParse(dolarField.Text, out precio);
            dolarField.Text = (precio - this.dolar).ToString() + ".00";
            if ((precio - 10) >= 0)
            {
                dolarField.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        private void navigationBar1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            decimal iva;
            var isIVA = decimal.TryParse(dolarField.Text, out iva);
            if (!isIVA)
            {
                Notifications.NotificationsCenter.ShowWarningMessage("Revisa el IVA", "Error tratando el guardar el IVA.");
                return;
            }

            decimal precio;
            var isDolar = decimal.TryParse(dolarField.Text, out precio);
            if (!isDolar)
            {
                Notifications.NotificationsCenter.ShowWarningMessage("Revisa el Dolar", "Error tratando el guardar el Dolar.");
                return;
            }

            settingsHelper.SetIVA(iva);
            settingsHelper.SetIsIvaActive(useIVACB.Checked);
            settingsHelper.SetDolar(dolar);
            settingsHelper.SetShouldCheckDolarUpdates(updateDolarCB.Checked);
            settingsHelper.SetShouldShowDolar(showDolarCB.Checked);
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {
            settingsHelper = SettingsHelper.getInstance();

            ivaField.Text = settingsHelper.GetIVA().ToString();
            useIVACB.Checked = settingsHelper.IsIvaActive();

            dolarField.Text = settingsHelper.GetDolar().ToString();
            showDolarCB.Checked = settingsHelper.ShouldShowDolar();
            updateDolarCB.Checked = settingsHelper.ShouldCheckDolarUpdates();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            decimal iva;
            var isIVA = decimal.TryParse(ivaField.Text, out iva);
            if (!isIVA)
            {
                Notifications.NotificationsCenter.ShowWarningMessage("Revisa el IVA", "Error tratando el guardar el IVA.");
                return;
            }

            float precio;
            var isDolar = float.TryParse(dolarField.Text, out precio);
            if (!isDolar)
            {
                Notifications.NotificationsCenter.ShowWarningMessage("Revisa el Dolar", "Error tratando el guardar el Dolar.");
                return;
            }

            settingsHelper.SetIVA(iva);
            settingsHelper.SetIsIvaActive(useIVACB.Checked);
            settingsHelper.SetDolar(precio);
            settingsHelper.SetShouldCheckDolarUpdates(updateDolarCB.Checked);
            settingsHelper.SetShouldShowDolar(showDolarCB.Checked);
            Close();
        }
    }
}
