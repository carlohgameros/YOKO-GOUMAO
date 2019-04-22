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
    public partial class Configuraciones : Form
    {
        private float iva = 1.00F;
        private float dolar = 0.50F;

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
    }
}
