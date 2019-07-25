using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOKO.Helpers
{
    public class Forms
    {
        public static Form form = new Form();

        public static void GoToNextForm(Form actualForm, Form nextForm)
        {
            form = nextForm;
            form.Show();
            actualForm.Close();
        }

       public static void GoToPreciousForm(Form actualForm)
        {
            form.Show();
            var temporaryForm = actualForm;
            actualForm.Close();
            form = temporaryForm;
        }
    }
}