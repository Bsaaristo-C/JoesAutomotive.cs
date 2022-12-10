using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaristo_Asg6_JoesAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearCheckBoxes();
            clearTextAndLabels();
        }

        private void clearTextAndLabels()
        {
            labelReturnLaborHoursTotal.Text = "";
            textBoxLaborHoursInput.Text = "0";
            textBoxPartsCostInput.Text = "0";
            textBoxPartsCostTotal.Text = null;
            textBoxServiceAndLaborCosts.Text = null;
            textBoxTaxCostOnParts.Text = null;
            textBoxTotalFees.Text = null;
        }

        private void clearCheckBoxes()
        {
            checkBoxInspection.Checked = false;
            checkBoxLubeJob.Checked = false;
            checkBoxOilCharge.Checked = false;
            checkBoxRadiatorFlush.Checked = false;
            checkBoxReplaceMuffler.Checked = false;
            checkBoxTireRotation.Checked = false;
            checkBoxTransFlush.Checked = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double oilAndLubeCharges = calculateOilLubeCharges();
            double miscCharges = calculateMiscCharges();
            double flushCharges = calculateFlushCharges();
            double laborCharges = calculateLaborCharges();
            double partsTaxTotal = calculatePartsCharges(textBoxPartsCostInput.Text);


            textBoxPartsCostTotal.Text = textBoxPartsCostInput.Text;

            textBoxTaxCostOnParts.Text = partsTaxTotal.ToString();
            textBoxServiceAndLaborCosts.Text = (oilAndLubeCharges + flushCharges + miscCharges + laborCharges).ToString();
            try
            {
                double totalFees = oilAndLubeCharges + flushCharges + miscCharges + laborCharges + partsTaxTotal + int.Parse(textBoxPartsCostInput.Text);
                textBoxTotalFees.Text = totalFees.ToString();

            }
            catch (Exception x)
            {
                textBoxPartsCostInput.Text = (x + "invalid input");
            }


        }

        private double calculateLaborCharges()
        {
            try
            {
                double sum = 0;
                sum = double.Parse(textBoxLaborHoursInput.Text) * 50;
                labelReturnLaborHoursTotal.Text = ("$" + sum).ToString();
                return sum;
            }
            catch(Exception e)
            {
                textBoxLaborHoursInput.Text = (e + "invalid input");
                return 0;
            }
        }

        private double calculateMiscCharges()
        {
            double sum = 0;
            if (checkBoxInspection.Checked)
                sum = sum + 15;
            if (checkBoxReplaceMuffler.Checked)
                sum = sum + 100;
            if (checkBoxTireRotation.Checked)
                sum = sum + 20;
            return sum;
        }

        private double calculateFlushCharges()
        {
            double sum = 0;
            if (checkBoxRadiatorFlush.Checked)
                sum = sum + 30;
            if (checkBoxTransFlush.Checked)
                sum = sum + 80;
            return sum;
        }

        private double calculateOilLubeCharges()
        {
            double sum = 0;
            if (checkBoxOilCharge.Checked)
                sum = sum + 26;
            if (checkBoxLubeJob.Checked)
                sum = sum + 18;
            return sum;
        }

        private double calculatePartsCharges(string text)
        {
            try
            {
                double total = 0;
                total = int.Parse(text);
                total = (total * .055);
                return total;
            }
            catch (Exception e)
            {
                textBoxPartsCostInput.Text = (e + "invalid input");
                return 0;
            }
            
            
        }
    }
}
