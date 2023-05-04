using System;
using System.Windows.Forms;

namespace Magnemi.Calculator.Lab04.App
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 0;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            leadingZeroRemover();
            lblDisplay.Text += 9;
        }

        private void btnIntegerDivision_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "\u005C";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            multipleOperationsIdentifier();
            lblDisplay.Text += '/';
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            multipleOperationsIdentifier();
            lblDisplay.Text += '*';
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            multipleOperationsIdentifier();
            lblDisplay.Text += '-';
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            multipleOperationsIdentifier();
            lblDisplay.Text += '+';
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            multipleOperationsIdentifier();
            lblDisplay.Text += "mod";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            multipleOperationsIdentifier();
            lblDisplay.Text += '%';
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            calculateNumbers();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length != 0)
                lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1);
        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        public void leadingZeroRemover()
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = String.Empty;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += '.';
        }

        private void btnPositiveAndNegativeToggle_Click_1(object sender, EventArgs e)
        {
            lblDisplay.Text += '\u207b';
        }

        public void calculateNumbers()
        {
            SixFunctions calculatorFunctions = new SixFunctions(lblDisplay.Text);

            lblDisplay.Text = calculatorFunctions.functionSelector();
        }

        public void multipleOperationsIdentifier()
        {
            if (lblDisplay.Text.IndexOfAny("+-*/\u005C".ToCharArray()) != -1)
            {
                calculateNumbers();
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += '%';
        }
    }
}
