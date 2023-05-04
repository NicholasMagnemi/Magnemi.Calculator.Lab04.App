namespace Magnemi.Calculator.Lab04.App
{
    partial class frmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnClearDisplay = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnPositiveAndNegativeToggle = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnIntegerDivision = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplay.Location = new System.Drawing.Point(3, 3);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(318, 23);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Location = new System.Drawing.Point(3, 28);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(156, 23);
            this.btnClearDisplay.TabIndex = 2;
            this.btnClearDisplay.Text = "AC";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(3, 57);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(75, 23);
            this.btnSeven.TabIndex = 11;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(3, 107);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 23);
            this.btnOne.TabIndex = 12;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(3, 82);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(75, 23);
            this.btnFour.TabIndex = 13;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnPositiveAndNegativeToggle
            // 
            this.btnPositiveAndNegativeToggle.Location = new System.Drawing.Point(3, 132);
            this.btnPositiveAndNegativeToggle.Name = "btnPositiveAndNegativeToggle";
            this.btnPositiveAndNegativeToggle.Size = new System.Drawing.Size(75, 23);
            this.btnPositiveAndNegativeToggle.TabIndex = 14;
            this.btnPositiveAndNegativeToggle.Text = "-/+";
            this.btnPositiveAndNegativeToggle.UseVisualStyleBackColor = true;
            this.btnPositiveAndNegativeToggle.Click += new System.EventHandler(this.btnPositiveAndNegativeToggle_Click_1);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(3, 157);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(237, 23);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "=";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Location = new System.Drawing.Point(3, 182);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(237, 23);
            this.btnExitApplication.TabIndex = 16;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = true;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(84, 58);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(75, 23);
            this.btnEight.TabIndex = 17;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(84, 82);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 23);
            this.btnFive.TabIndex = 18;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(84, 107);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 23);
            this.btnTwo.TabIndex = 19;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(84, 132);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 23);
            this.btnZero.TabIndex = 20;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(165, 58);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(75, 23);
            this.btnNine.TabIndex = 21;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(165, 82);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(75, 23);
            this.btnSix.TabIndex = 22;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(165, 107);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 23);
            this.btnThree.TabIndex = 23;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(165, 132);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnIntegerDivision
            // 
            this.btnIntegerDivision.Location = new System.Drawing.Point(246, 57);
            this.btnIntegerDivision.Name = "btnIntegerDivision";
            this.btnIntegerDivision.Size = new System.Drawing.Size(75, 23);
            this.btnIntegerDivision.TabIndex = 25;
            this.btnIntegerDivision.Text = "INT DIV";
            this.btnIntegerDivision.UseVisualStyleBackColor = true;
            this.btnIntegerDivision.Click += new System.EventHandler(this.btnIntegerDivision_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(246, 82);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 26;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(246, 108);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplication.TabIndex = 27;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(246, 132);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(75, 23);
            this.btnSubtraction.TabIndex = 28;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(246, 157);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 29;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnModulus
            // 
            this.btnModulus.Location = new System.Drawing.Point(246, 183);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(75, 23);
            this.btnModulus.TabIndex = 30;
            this.btnModulus.Text = "MOD";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.btnModulus_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.Location = new System.Drawing.Point(246, 28);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(75, 23);
            this.btnPercentage.TabIndex = 31;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 208);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnIntegerDivision);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnPositiveAndNegativeToggle);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClearDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnPositiveAndNegativeToggle;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnIntegerDivision;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnPercentage;
    }
}
