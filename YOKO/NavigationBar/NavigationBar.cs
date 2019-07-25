using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOKO.NavigationBar
{
    public partial class NavigationBar : UserControl
    {
        private static iNavigation navigation;
        private static Form form;
        public NavigationBar()
        {
            InitializeComponent();
            navigation = new Navigation();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) => navigation.ReturnToPreviousForm(ParentForm);

        private void bunifuImageButton3_Click(object sender, EventArgs e) => navigation.HideForm(ParentForm);

        private void bunifuImageButton4_Click(object sender, EventArgs e) => navigation.CloseForm(ParentForm);

        public void HideTitle() => navigationTitle.Visible = false;

        public void HideBackButton() => backButton.Visible = false;
    }
}
