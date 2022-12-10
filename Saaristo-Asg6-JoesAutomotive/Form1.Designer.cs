namespace Saaristo_Asg6_JoesAutomotive
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLubeJob = new System.Windows.Forms.CheckBox();
            this.checkBoxOilCharge = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxInspection = new System.Windows.Forms.CheckBox();
            this.checkBoxReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.checkBoxTireRotation = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPartsCostInput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelReturnLaborHoursTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLaborHoursInput = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.checkBoxTransFlush = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxServiceAndLaborCosts = new System.Windows.Forms.TextBox();
            this.textBoxPartsCostTotal = new System.Windows.Forms.TextBox();
            this.textBoxTaxCostOnParts = new System.Windows.Forms.TextBox();
            this.textBoxTotalFees = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLubeJob);
            this.groupBox1.Controls.Add(this.checkBoxOilCharge);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // checkBoxLubeJob
            // 
            this.checkBoxLubeJob.AutoSize = true;
            this.checkBoxLubeJob.Location = new System.Drawing.Point(6, 42);
            this.checkBoxLubeJob.Name = "checkBoxLubeJob";
            this.checkBoxLubeJob.Size = new System.Drawing.Size(109, 17);
            this.checkBoxLubeJob.TabIndex = 1;
            this.checkBoxLubeJob.Text = "Lube job ($18.00)";
            this.checkBoxLubeJob.UseVisualStyleBackColor = true;
            // 
            // checkBoxOilCharge
            // 
            this.checkBoxOilCharge.AutoSize = true;
            this.checkBoxOilCharge.Location = new System.Drawing.Point(6, 19);
            this.checkBoxOilCharge.Name = "checkBoxOilCharge";
            this.checkBoxOilCharge.Size = new System.Drawing.Size(119, 17);
            this.checkBoxOilCharge.TabIndex = 0;
            this.checkBoxOilCharge.Text = "Oil change ($26.00)";
            this.checkBoxOilCharge.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxInspection);
            this.groupBox2.Controls.Add(this.checkBoxReplaceMuffler);
            this.groupBox2.Controls.Add(this.checkBoxTireRotation);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // checkBoxInspection
            // 
            this.checkBoxInspection.AutoSize = true;
            this.checkBoxInspection.Location = new System.Drawing.Point(6, 20);
            this.checkBoxInspection.Name = "checkBoxInspection";
            this.checkBoxInspection.Size = new System.Drawing.Size(117, 17);
            this.checkBoxInspection.TabIndex = 4;
            this.checkBoxInspection.Text = "Inspection ($15.00)";
            this.checkBoxInspection.UseVisualStyleBackColor = true;
            // 
            // checkBoxReplaceMuffler
            // 
            this.checkBoxReplaceMuffler.AutoSize = true;
            this.checkBoxReplaceMuffler.Location = new System.Drawing.Point(6, 43);
            this.checkBoxReplaceMuffler.Name = "checkBoxReplaceMuffler";
            this.checkBoxReplaceMuffler.Size = new System.Drawing.Size(148, 17);
            this.checkBoxReplaceMuffler.TabIndex = 5;
            this.checkBoxReplaceMuffler.Text = "Replace muffler ($100.00)";
            this.checkBoxReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // checkBoxTireRotation
            // 
            this.checkBoxTireRotation.AutoSize = true;
            this.checkBoxTireRotation.Location = new System.Drawing.Point(6, 66);
            this.checkBoxTireRotation.Name = "checkBoxTireRotation";
            this.checkBoxTireRotation.Size = new System.Drawing.Size(124, 17);
            this.checkBoxTireRotation.TabIndex = 6;
            this.checkBoxTireRotation.Text = "Tire rotation ($20.00)";
            this.checkBoxTireRotation.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxPartsCostInput);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 53);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parts Total: ";
            // 
            // textBoxPartsCostInput
            // 
            this.textBoxPartsCostInput.Location = new System.Drawing.Point(76, 19);
            this.textBoxPartsCostInput.Name = "textBoxPartsCostInput";
            this.textBoxPartsCostInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartsCostInput.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.labelReturnLaborHoursTotal);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxLaborHoursInput);
            this.groupBox4.Location = new System.Drawing.Point(268, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 73);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Labor";
            // 
            // labelReturnLaborHoursTotal
            // 
            this.labelReturnLaborHoursTotal.AutoSize = true;
            this.labelReturnLaborHoursTotal.Location = new System.Drawing.Point(91, 51);
            this.labelReturnLaborHoursTotal.Name = "labelReturnLaborHoursTotal";
            this.labelReturnLaborHoursTotal.Size = new System.Drawing.Size(0, 13);
            this.labelReturnLaborHoursTotal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Labor Hours: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Labor total:";
            // 
            // textBoxLaborHoursInput
            // 
            this.textBoxLaborHoursInput.Location = new System.Drawing.Point(94, 19);
            this.textBoxLaborHoursInput.Name = "textBoxLaborHoursInput";
            this.textBoxLaborHoursInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxLaborHoursInput.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxRadiatorFlush);
            this.groupBox5.Controls.Add(this.checkBoxTransFlush);
            this.groupBox5.Location = new System.Drawing.Point(268, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 82);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Flushes";
            // 
            // checkBoxRadiatorFlush
            // 
            this.checkBoxRadiatorFlush.AutoSize = true;
            this.checkBoxRadiatorFlush.Location = new System.Drawing.Point(6, 26);
            this.checkBoxRadiatorFlush.Name = "checkBoxRadiatorFlush";
            this.checkBoxRadiatorFlush.Size = new System.Drawing.Size(133, 17);
            this.checkBoxRadiatorFlush.TabIndex = 2;
            this.checkBoxRadiatorFlush.Text = "Radiator flush ($30.00)";
            this.checkBoxRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransFlush
            // 
            this.checkBoxTransFlush.AutoSize = true;
            this.checkBoxTransFlush.Location = new System.Drawing.Point(6, 49);
            this.checkBoxTransFlush.Name = "checkBoxTransFlush";
            this.checkBoxTransFlush.Size = new System.Drawing.Size(157, 17);
            this.checkBoxTransFlush.TabIndex = 3;
            this.checkBoxTransFlush.Text = "Transmission Flush ($80.00)";
            this.checkBoxTransFlush.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxTotalFees);
            this.groupBox6.Controls.Add(this.textBoxTaxCostOnParts);
            this.groupBox6.Controls.Add(this.textBoxPartsCostTotal);
            this.groupBox6.Controls.Add(this.textBoxServiceAndLaborCosts);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(12, 238);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(595, 119);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tax (On parts @ 5.5%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service and labor:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 363);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(103, 50);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(121, 363);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 50);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(486, 363);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 50);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxServiceAndLaborCosts
            // 
            this.textBoxServiceAndLaborCosts.Location = new System.Drawing.Point(126, 10);
            this.textBoxServiceAndLaborCosts.Name = "textBoxServiceAndLaborCosts";
            this.textBoxServiceAndLaborCosts.ReadOnly = true;
            this.textBoxServiceAndLaborCosts.Size = new System.Drawing.Size(100, 20);
            this.textBoxServiceAndLaborCosts.TabIndex = 7;
            // 
            // textBoxPartsCostTotal
            // 
            this.textBoxPartsCostTotal.Location = new System.Drawing.Point(126, 36);
            this.textBoxPartsCostTotal.Name = "textBoxPartsCostTotal";
            this.textBoxPartsCostTotal.ReadOnly = true;
            this.textBoxPartsCostTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartsCostTotal.TabIndex = 8;
            // 
            // textBoxTaxCostOnParts
            // 
            this.textBoxTaxCostOnParts.Location = new System.Drawing.Point(126, 62);
            this.textBoxTaxCostOnParts.Name = "textBoxTaxCostOnParts";
            this.textBoxTaxCostOnParts.ReadOnly = true;
            this.textBoxTaxCostOnParts.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaxCostOnParts.TabIndex = 9;
            // 
            // textBoxTotalFees
            // 
            this.textBoxTotalFees.Location = new System.Drawing.Point(126, 93);
            this.textBoxTotalFees.Name = "textBoxTotalFees";
            this.textBoxTotalFees.ReadOnly = true;
            this.textBoxTotalFees.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalFees.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Labor is $50 per hour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 435);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Saaristo Asg6 JoesAutomotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxLubeJob;
        private System.Windows.Forms.CheckBox checkBoxOilCharge;
        private System.Windows.Forms.CheckBox checkBoxInspection;
        private System.Windows.Forms.CheckBox checkBoxReplaceMuffler;
        private System.Windows.Forms.CheckBox checkBoxTireRotation;
        private System.Windows.Forms.TextBox textBoxPartsCostInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLaborHoursInput;
        private System.Windows.Forms.CheckBox checkBoxRadiatorFlush;
        private System.Windows.Forms.CheckBox checkBoxTransFlush;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelReturnLaborHoursTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotalFees;
        private System.Windows.Forms.TextBox textBoxTaxCostOnParts;
        private System.Windows.Forms.TextBox textBoxPartsCostTotal;
        private System.Windows.Forms.TextBox textBoxServiceAndLaborCosts;
        private System.Windows.Forms.Label label8;
    }
}

