/* Program:         HW05 - Assignment 11
 * Developed by:    Christopher Karnas
 * Date Created:    October 2020
 * Last Modified:   11.03.20
 * Class Name:      Form1
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //enable/disable controls at start
            grpTankData.Enabled = false;
            grpAddWithdraw.Enabled = false;
            grpFillDrain.Enabled = false;
            radAddWater.Checked = true;
            radFillWater.Checked = true;
        }

        //instantiate object/ declare class level variables
        WaterTank aWaterTank;

        private void btnCreateTank_Click(object sender, EventArgs e)
        {
            //declare method level variables
            int radius, depth;

            //assign values
            radius = Convert.ToInt32(nudRadius.Value);
            depth = Convert.ToInt32(nudDepth.Value);

            //instantiate an object
            aWaterTank = new WaterTank(radius, depth);

            //disable/enable controls
            grpTankData.Enabled = true;
            grpAddWithdraw.Enabled = true;
            grpFillDrain.Enabled = true;
            grpTankDimensions.Enabled = false;
        }

        //display current water level
        private void btnCurrentWaterLevel_Click(object sender, EventArgs e)
        {
            lblCurrentLevel.Text = aWaterTank.WaterLevel.ToString("n0") + " Liters";
        }

        //display max water capacity
        private void btnMaxCapacity_Click(object sender, EventArgs e)
        {
            lblMaxCapacity.Text = aWaterTank.MaxCapacity.ToString("n0") + " Liters";

            //disable button
            btnMaxCapacity.Enabled = false;
        }

        //display withdrawal rate
        private void btnAddWithdraw_Click(object sender, EventArgs e)
        {
            int liters = Convert.ToInt32(nudLevel.Value);
            lblAddWithdrawMessage.Text = (radAddWater.Checked) ? aWaterTank.AddWater(liters) : aWaterTank.WithdrawWater(liters);
        }

        //display fill rate
        private void btnFillDrain_Click(object sender, EventArgs e)
        {
            //declare variables
            string output = string.Empty;
            int litersPerSec = Convert.ToInt32(nudLitPsec.Value);

            //if Fill radio button is checked
            if (radFillWater.Checked)
            {
                //loop for unknown iterations
                while (aWaterTank.FillTank(litersPerSec))
                {
                    //variable (operator +) grab the class parameter. Convert datatype.
                    output += aWaterTank.WaterLevel.ToString("n0") + " Liters \r\n";
                    txtFillDrainPS.Text = output;
                }
                //when the loop cannot go any further, display the result with a message
                txtFillDrainPS.Text = output += "Fill Rate Capacity has been reached";
            }
            else //(radDrainWater.Checked)
            {
                //if Drain Tank is selected
                while (aWaterTank.DrainTank(litersPerSec))
                {
                    output += aWaterTank.WaterLevel.ToString("n0") + " Liters \r\n";
                    txtFillDrainPS.Text = output;
                }
                //display result
                txtFillDrainPS.Text = output += "Drain Rate Limit has been reached";
            }
            //// What would I do for a rate that has a little left in the tank, but can't display "tank empty"? 
            /// Or I want to display tank empty, but not for the rates at which leave a little bit of water?
        }

        //reset the form
        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset values
            nudDepth.Value = nudDepth.Minimum;
            nudRadius.Value = nudRadius.Minimum;
            nudLevel.Value = nudLevel.Minimum;
            nudLitPsec.Value = nudLitPsec.Minimum;

            //clear text
            lblCurrentLevel.Text = null;
            lblMaxCapacity.Text = null;
            lblAddWithdrawMessage.Text = null;
            txtFillDrainPS.Text = null;

            //enable/disable controls
            grpTankData.Enabled = false;
            grpAddWithdraw.Enabled = false;
            grpFillDrain.Enabled = false;
            grpTankDimensions.Enabled = true;
            btnCreateTank.Enabled = true;
            btnMaxCapacity.Enabled = true;
        }

        //exit the form, with warning prompt
        private void btnExit_Click(object sender, EventArgs e)
        {
            // declare variable
            DialogResult aResult;

            // assign the return value to the variable
            aResult = MessageBox.Show("Do you wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // take action based on the value of aResult
            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                nudRadius.Focus();
            }
        }
    }
}
