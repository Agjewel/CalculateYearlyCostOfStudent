using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateYearlyCostOfStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //string firstInput = Convert.ToString(ClassComboBox.Items.Add("Class 1"));
            //string secInput = Convert.ToString(ClassComboBox.Items.Add("Class 2"));

            //string thirdInput = Convert.ToString(ClassComboBox.Items.Add("Class 3"));
            //string forthInput = Convert.ToString(ClassComboBox.Items.Add("Class 4"));
            //string fifthInput = Convert.ToString(ClassComboBox.Items.Add("Class 5"));
            //string sixthInput = Convert.ToString(ClassComboBox.Items.Add("Class 6"));
            //string seventhInput = Convert.ToString(ClassComboBox.Items.Add("Class 7"));
            //string eightInput = Convert.ToString(ClassComboBox.Items.Add("Class 8"));
            //string ninthInput = Convert.ToString(ClassComboBox.Items.Add("Class 9"));
            //string tenInput = Convert.ToString(ClassComboBox.Items.Add("Class 10"));
            //string elevenInput = Convert.ToString(ClassComboBox.Items.Add("Class 11"));
            //string twelveInput = Convert.ToString(ClassComboBox.Items.Add("Class 12"));


           
            if (ClassComboBox.Text == "Class 1" && DiscountCheckBox.Checked)
            {
                int totalAmount =10000 + (500*12) - 500;
                MessageBox.Show(totalAmount.ToString());

            }
            else if (ClassComboBox.Text == "Class 1" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (500 * 12);
                
                MessageBox.Show(totalAmount.ToString());
            }
            else if (ClassComboBox.Text == "Class 2" && DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (500 * 12) -500;

                MessageBox.Show(totalAmount.ToString());
            }
            else if (ClassComboBox.Text == "Class 2" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (500 * 12);

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 3" && DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (1000 * 12) -500;

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 3" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (1000 * 12);

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 4" && DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (1000 * 12) - 500;

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 4" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (1000 * 12);

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 5" && DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (1000 * 2)-500;

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 5" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 10000 + (1000 * 12);

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 6" && DiscountCheckBox.Checked)
            {
                int totalAmount = 12000 + (1500 * 12) -600;

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 6" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 12000 + (1500 * 12);

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 7" && DiscountCheckBox.Checked)
            {
                int totalAmount = 12000 + (1500 * 12)-600;

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 7" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 12000 + (1500 * 12);

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 8" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 12000 + (1500 * 12);

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 8" && DiscountCheckBox.Checked)
            {
                int totalAmount = 12000 + (1500 * 12) - 600;

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 9" && !DiscountCheckBox.Checked)
            {
                int totalAmount = 12000 + (1500 * 12);

                MessageBox.Show(totalAmount.ToString());
            }

            else if (ClassComboBox.Text == "Class 9" && DiscountCheckBox.Checked)
            {
                int totalAmount = 15000 + (2000 * 12) - 750;

                MessageBox.Show(totalAmount.ToString());
            }


        }
    }
}
