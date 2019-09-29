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

namespace YOKO.Helpers
{
    public class Forms
    {
        public static Form actualForm = new Form();
        public static Form previousForm = new Form();

        public static void GoToNextForm(Form actualForm, Form nextForm)
        {
            ChangeForms();
            actualForm = nextForm;
            actualForm.Show();
            previousForm.Hide();
        }

       public static void GoToPreviousForm(Form parentForm)
        {
            Form inicio = new Inicio();
            inicio.Show();
            actualForm = parentForm;
            actualForm.Hide();
            ChangeForms();
        }

        public static void CloseProgram(Form actualForm)
        {
            actualForm.Close();
        }

        public static void HideProgram(Form actualForm) => actualForm.WindowState = FormWindowState.Minimized;

        public static void ChangeForms() => previousForm = actualForm;
    }
}