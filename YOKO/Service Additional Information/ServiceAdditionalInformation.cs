using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YOKO.Models;

namespace YOKO.Service_Additional_Information
{
    public partial class ServiceAdditionalInformation : Form
    {
        private IServiceInformationAdded listener;
        private List<int> knifeSizes = new List<int> { 4, 5, 7, 8 ,9 };
        private List<string> shampoos = new List<string> { "test 1", "test 2", "test 3" };
        private int size = 0;
        private int index = 0;
        private int id = 0;
        private int hairCutID = 171;
        private int showerID = 2;

        public ServiceAdditionalInformation(int index, int id, IServiceInformationAdded listener)
        {
            InitializeComponent();
            this.index = index;
            this.listener = listener;
            this.id = id;

            navigationBar1.HideBackButton();

            HandleSizeVisibility();
        }

        private void HandleSizeVisibility()
        {
            if (IsHairCut() || IsShower())
            {
                knifeTextBox.Visible = true;
                upButton.Visible = true;
                downButton.Visible = true;

                if (IsShower())
                {
                    knifeTextBox.Text = "Shampoo";
                } 
            }
            else
            {
                knifeTextBox.Visible = false;
                upButton.Visible = false;
                downButton.Visible = false;
            }
        }

        private Boolean IsHairCut() => id == hairCutID;

        private Boolean IsShower() => id == showerID;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void ServiceAdditionalInformation_Load(object sender, EventArgs e)
        {
            navigationBar1.ChangeNavigationTitle($"Agregar Observaciones");
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int result;
            if (IsHairCut())
            {
                if (int.TryParse(knifeTextBox.Text, out result))
                {
                    knifeTextBox.Text = knifeSizes.SkipWhile(x => x != result).Skip(1).DefaultIfEmpty(knifeSizes[knifeSizes.Count - 1]).FirstOrDefault().ToString();
                }
                else
                {
                    knifeTextBox.Text = knifeSizes[0].ToString();
                }
                
            }
            else if (IsShower())
            {
                if (int.TryParse(knifeTextBox.Text, out result))
                {
                    knifeTextBox.Text = shampoos.SkipWhile(x => x != result.ToString()).Skip(1).DefaultIfEmpty(shampoos[shampoos.Count - 1]).FirstOrDefault();
                }
                else
                {
                    knifeTextBox.Text = shampoos[0];
                }
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            //knifeTextBox.Text = int.TryParse(knifeTextBox.Text, out size) ? (size - 1).ToString() : 0.ToString();
            int result;
            if (IsHairCut())
            {
                if (int.TryParse(knifeTextBox.Text, out result))
                {
                    knifeTextBox.Text = knifeSizes.SkipWhile(x => x != result).DefaultIfEmpty(knifeSizes[0]).LastOrDefault().ToString();
                }
                else
                {
                    knifeTextBox.Text = knifeSizes[0].ToString();
                }

            }
            else if (IsShower())
            {
                if (int.TryParse(knifeTextBox.Text, out result))
                {
                    knifeTextBox.Text = shampoos.SkipWhile(x => x != result.ToString()).DefaultIfEmpty(shampoos[0]).LastOrDefault();
                }
                else
                {
                    knifeTextBox.Text = shampoos[0];
                }
            }
        }

        private void knifeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                upButton_Click(null, null);
            }
            else if (e.KeyCode == Keys.Down)
            {
                downButton_Click(null, null);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            listener.OnServiceInformationAdded(index, ObservationsTextBox.Text, int.TryParse(knifeTextBox.Text, out size) ? size : 0);
            Close();
        }
    }
}
