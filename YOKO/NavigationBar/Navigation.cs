using System;
using System.Drawing;
using System.Windows.Forms;
using YOKO.Helpers;

namespace YOKO.NavigationBar
{
    class Navigation : iNavigation
    {
        public static String title;

        public void AdaptNavigationSize() => throw new NotImplementedException();

        public void ChangeNavigationTitle(String newTitle) => title = newTitle;

        public void CloseForm(Form actualForm) => Forms.CloseProgram(actualForm);

        public void HideForm(Form actualForm) => Forms.HideProgram(actualForm);

        public void ReturnToPreviousForm(Form parentForm) => Forms.GoToPreviousForm(parentForm);

        public void ChangeBackgroundColor(Color color) {}
    }
}
