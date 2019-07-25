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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new Venta(BasicData.GetSellerName()));

        private void label4_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new Productos());

        private void label6_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new Tickets());

        private void label5_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new NuevoUsuario());

        private void label8_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new AltasSecundarias());

        private void label9_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new DatosFiscales());

        private void label7_Click(object sender, EventArgs e) => Forms.GoToNextForm(actualForm: this, nextForm: new Configuraciones());
    }
}
