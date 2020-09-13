using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YOKO.Helpers;

namespace YOKO.NavigationBar
{
    public partial class NavigationBar : UserControl, iNavigation
    {
        private static iNavigation navigation;
        int movument;
        int xPosition;
        int yPosition;

        public NavigationBar()
        {
            InitializeComponent();
            navigation = new Navigation();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) => navigation.ReturnToPreviousForm(ParentForm);

        private void bunifuImageButton3_Click(object sender, EventArgs e) => navigation.HideForm(ParentForm);

        private void bunifuImageButton4_Click(object sender, EventArgs e) => ParentForm.Close();

        public void HideTitle() => navigationTitle.Visible = false;

        public void HideBackButton() => backButton.Visible = false;
        
        private void SetBackColorAsTransparet() => this.BackColor = Color.FromArgb(0, 1, 1, 1);

        private void SetBackColorFromParentForm(Form parentForm) => this.BackColor = parentForm.BackColor;

        private void NavigationBar_Load(object sender, EventArgs e) => navigationTitle.Text = ParentForm.Text;

        public void AdaptNavigationSize() => throw new NotImplementedException();

        public void ChangeNavigationTitle(String newTitle) => navigationTitle.Text = newTitle;

        public void CloseForm(Form actualForm) => Forms.CloseProgram(actualForm);

        public void HideForm(Form actualForm) => Forms.HideProgram(actualForm);

        public void ReturnToPreviousForm(Form parentForm) => Forms.GoToPreviousForm(parentForm);

        public void ChangeBackgroundColor(Color color) => BackColor = color;

        private void navigationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navigationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            movument = 1;
            xPosition = e.X;
            yPosition = e.Y;
        }

        private void navigationPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (movument == 1)
            {
                ParentForm.SetDesktopLocation(MousePosition.X - xPosition, MousePosition.Y - yPosition);
            }
        }

        private void navigationPanel_MouseUp(object sender, MouseEventArgs e)
        {
            movument = 0;
        }
    }
}
