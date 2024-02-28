namespace Depreciation_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SumOfYearsRadioButton = new System.Windows.Forms.RadioButton();
            this.StraightLineComboBox = new System.Windows.Forms.RadioButton();
            this.InitialCostTextBox = new System.Windows.Forms.TextBox();
            this.SalvageValueTextBox = new System.Windows.Forms.TextBox();
            this.UsefulLifeComboBox = new System.Windows.Forms.ComboBox();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.UpdateScheduleButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salvage Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Useful Life";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Depreciation Schedule";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Depreciation Method";
            // 
            // SumOfYearsRadioButton
            // 
            this.SumOfYearsRadioButton.AutoSize = true;
            this.SumOfYearsRadioButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumOfYearsRadioButton.Location = new System.Drawing.Point(334, 88);
            this.SumOfYearsRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SumOfYearsRadioButton.Name = "SumOfYearsRadioButton";
            this.SumOfYearsRadioButton.Size = new System.Drawing.Size(107, 18);
            this.SumOfYearsRadioButton.TabIndex = 5;
            this.SumOfYearsRadioButton.TabStop = true;
            this.SumOfYearsRadioButton.Text = "Sum of Years (SYD)";
            this.SumOfYearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // StraightLineComboBox
            // 
            this.StraightLineComboBox.AutoSize = true;
            this.StraightLineComboBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StraightLineComboBox.Location = new System.Drawing.Point(334, 113);
            this.StraightLineComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StraightLineComboBox.Name = "StraightLineComboBox";
            this.StraightLineComboBox.Size = new System.Drawing.Size(103, 18);
            this.StraightLineComboBox.TabIndex = 6;
            this.StraightLineComboBox.TabStop = true;
            this.StraightLineComboBox.Text = "Straight Line (SLN)";
            this.StraightLineComboBox.UseVisualStyleBackColor = true;
            // 
            // InitialCostTextBox
            // 
            this.InitialCostTextBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialCostTextBox.Location = new System.Drawing.Point(127, 48);
            this.InitialCostTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InitialCostTextBox.Name = "InitialCostTextBox";
            this.InitialCostTextBox.Size = new System.Drawing.Size(84, 19);
            this.InitialCostTextBox.TabIndex = 7;
            // 
            // SalvageValueTextBox
            // 
            this.SalvageValueTextBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalvageValueTextBox.Location = new System.Drawing.Point(127, 95);
            this.SalvageValueTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SalvageValueTextBox.Name = "SalvageValueTextBox";
            this.SalvageValueTextBox.Size = new System.Drawing.Size(84, 19);
            this.SalvageValueTextBox.TabIndex = 8;
            // 
            // UsefulLifeComboBox
            // 
            this.UsefulLifeComboBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsefulLifeComboBox.FormattingEnabled = true;
            this.UsefulLifeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.UsefulLifeComboBox.Location = new System.Drawing.Point(127, 129);
            this.UsefulLifeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UsefulLifeComboBox.Name = "UsefulLifeComboBox";
            this.UsefulLifeComboBox.Size = new System.Drawing.Size(102, 22);
            this.UsefulLifeComboBox.TabIndex = 9;
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 14;
            this.OutputListBox.Location = new System.Drawing.Point(54, 210);
            this.OutputListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(412, 116);
            this.OutputListBox.TabIndex = 10;
            // 
            // UpdateScheduleButton
            // 
            this.UpdateScheduleButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateScheduleButton.Location = new System.Drawing.Point(191, 351);
            this.UpdateScheduleButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateScheduleButton.Name = "UpdateScheduleButton";
            this.UpdateScheduleButton.Size = new System.Drawing.Size(143, 25);
            this.UpdateScheduleButton.TabIndex = 11;
            this.UpdateScheduleButton.Text = "Update Schedule";
            this.UpdateScheduleButton.UseVisualStyleBackColor = true;
            this.UpdateScheduleButton.Click += new System.EventHandler(this.UpdateScheduleButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 434);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 401);
            this.Controls.Add(this.UpdateScheduleButton);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.UsefulLifeComboBox);
            this.Controls.Add(this.SalvageValueTextBox);
            this.Controls.Add(this.InitialCostTextBox);
            this.Controls.Add(this.StraightLineComboBox);
            this.Controls.Add(this.SumOfYearsRadioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton SumOfYearsRadioButton;
        private System.Windows.Forms.RadioButton StraightLineComboBox;
        private System.Windows.Forms.TextBox InitialCostTextBox;
        private System.Windows.Forms.TextBox SalvageValueTextBox;
        private System.Windows.Forms.ComboBox UsefulLifeComboBox;
        private System.Windows.Forms.ListBox OutputListBox;
        private System.Windows.Forms.Button UpdateScheduleButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

