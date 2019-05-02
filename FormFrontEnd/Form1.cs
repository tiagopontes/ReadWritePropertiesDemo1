using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {
        Balloon myFirstBallonn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                // i must instantiate my object
                myFirstBallonn = new Balloon()
                {
                    Colour = txtColor.Text.Trim(),
                    Diameter = Convert.ToDecimal(txtDiameter.Text.Trim()),
                    Height = Convert.ToDecimal(txtHeight.Text.Trim())
                };

                //myFirstBallonn.Colour = txtColor.Text.Trim();
                //myFirstBallonn.Diameter = Convert.ToDecimal(txtDiameter.Text.Trim());
                //myFirstBallonn.Height = Convert.ToDecimal(txtHeight.Text.Trim());

            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop); ;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                lblOutput.Text = $"Colour: {myFirstBallonn.Colour}\n" +
                    $"Height: {myFirstBallonn.Height}\n" +
                    $"Diameter: {myFirstBallonn.Diameter}";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
