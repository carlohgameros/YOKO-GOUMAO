using System;
using System.Windows.Forms;

namespace YOKO.NavigationBar
{
    interface iNavigation
    {
        void ReturnToPreviousForm(Form parentForm);

        void CloseForm(Form actualForm);

        void HideForm(Form actualForm);

        void ChangeNavigationTitle(String newTitle);

        void AdaptNavigationSize();
    }
}
