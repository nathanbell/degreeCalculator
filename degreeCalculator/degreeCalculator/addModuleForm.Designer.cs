namespace degreeCalculator
{
    partial class addModuleForm
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
            this.moduleTextLabel = new System.Windows.Forms.Label();
            this.semesterTextLabel = new System.Windows.Forms.Label();
            this.creditsTextLabel = new System.Windows.Forms.Label();
            this.levelTextLabel = new System.Windows.Forms.Label();
            this.moduleNameTextbox = new System.Windows.Forms.TextBox();
            this.semesterCombobox = new System.Windows.Forms.ComboBox();
            this.creditCombobox = new System.Windows.Forms.ComboBox();
            this.moduleCodeTextLabel = new System.Windows.Forms.Label();
            this.moduleCodeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitModuleButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.createAssessButton = new System.Windows.Forms.Button();
            this.numericUpDownAssessment = new System.Windows.Forms.NumericUpDown();
            this.levelPlaceholder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssessment)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleTextLabel
            // 
            this.moduleTextLabel.AutoSize = true;
            this.moduleTextLabel.Location = new System.Drawing.Point(103, 29);
            this.moduleTextLabel.Name = "moduleTextLabel";
            this.moduleTextLabel.Size = new System.Drawing.Size(76, 13);
            this.moduleTextLabel.TabIndex = 0;
            this.moduleTextLabel.Text = "Module Name:";
            // 
            // semesterTextLabel
            // 
            this.semesterTextLabel.AutoSize = true;
            this.semesterTextLabel.Location = new System.Drawing.Point(122, 87);
            this.semesterTextLabel.Name = "semesterTextLabel";
            this.semesterTextLabel.Size = new System.Drawing.Size(54, 13);
            this.semesterTextLabel.TabIndex = 1;
            this.semesterTextLabel.Text = "Semester:";
            // 
            // creditsTextLabel
            // 
            this.creditsTextLabel.AutoSize = true;
            this.creditsTextLabel.Location = new System.Drawing.Point(255, 87);
            this.creditsTextLabel.Name = "creditsTextLabel";
            this.creditsTextLabel.Size = new System.Drawing.Size(42, 13);
            this.creditsTextLabel.TabIndex = 2;
            this.creditsTextLabel.Text = "Credits:";
            // 
            // levelTextLabel
            // 
            this.levelTextLabel.AutoSize = true;
            this.levelTextLabel.Location = new System.Drawing.Point(261, 59);
            this.levelTextLabel.Name = "levelTextLabel";
            this.levelTextLabel.Size = new System.Drawing.Size(36, 13);
            this.levelTextLabel.TabIndex = 3;
            this.levelTextLabel.Text = "Level:";
            this.levelTextLabel.Click += new System.EventHandler(this.levelTextLabel_Click);
            // 
            // moduleNameTextbox
            // 
            this.moduleNameTextbox.AcceptsTab = true;
            this.moduleNameTextbox.Location = new System.Drawing.Point(179, 29);
            this.moduleNameTextbox.Name = "moduleNameTextbox";
            this.moduleNameTextbox.Size = new System.Drawing.Size(237, 20);
            this.moduleNameTextbox.TabIndex = 4;
            // 
            // semesterCombobox
            // 
            this.semesterCombobox.FormattingEnabled = true;
            this.semesterCombobox.Items.AddRange(new object[] {
            "One",
            "Two",
            "Year Long"});
            this.semesterCombobox.Location = new System.Drawing.Point(179, 84);
            this.semesterCombobox.Name = "semesterCombobox";
            this.semesterCombobox.Size = new System.Drawing.Size(62, 21);
            this.semesterCombobox.TabIndex = 6;
            // 
            // creditCombobox
            // 
            this.creditCombobox.FormattingEnabled = true;
            this.creditCombobox.Items.AddRange(new object[] {
            "15",
            "30"});
            this.creditCombobox.Location = new System.Drawing.Point(301, 84);
            this.creditCombobox.Name = "creditCombobox";
            this.creditCombobox.Size = new System.Drawing.Size(61, 21);
            this.creditCombobox.TabIndex = 7;
            // 
            // moduleCodeTextLabel
            // 
            this.moduleCodeTextLabel.AutoSize = true;
            this.moduleCodeTextLabel.Location = new System.Drawing.Point(103, 56);
            this.moduleCodeTextLabel.Name = "moduleCodeTextLabel";
            this.moduleCodeTextLabel.Size = new System.Drawing.Size(73, 13);
            this.moduleCodeTextLabel.TabIndex = 8;
            this.moduleCodeTextLabel.Text = "Module Code:";
            // 
            // moduleCodeTextbox
            // 
            this.moduleCodeTextbox.AcceptsTab = true;
            this.moduleCodeTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.moduleCodeTextbox.Location = new System.Drawing.Point(179, 56);
            this.moduleCodeTextbox.Name = "moduleCodeTextbox";
            this.moduleCodeTextbox.Size = new System.Drawing.Size(62, 20);
            this.moduleCodeTextbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Course Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Assessment Details";
            // 
            // submitModuleButton
            // 
            this.submitModuleButton.Location = new System.Drawing.Point(489, 344);
            this.submitModuleButton.Name = "submitModuleButton";
            this.submitModuleButton.Size = new System.Drawing.Size(75, 23);
            this.submitModuleButton.TabIndex = 16;
            this.submitModuleButton.Text = "Submit Module";
            this.submitModuleButton.UseVisualStyleBackColor = true;
            this.submitModuleButton.Click += new System.EventHandler(this.submitModuleButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Number of Assessment\'s";
            // 
            // createAssessButton
            // 
            this.createAssessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAssessButton.Location = new System.Drawing.Point(238, 135);
            this.createAssessButton.Name = "createAssessButton";
            this.createAssessButton.Size = new System.Drawing.Size(75, 23);
            this.createAssessButton.TabIndex = 19;
            this.createAssessButton.Text = "Create Assessment(s)";
            this.createAssessButton.UseVisualStyleBackColor = true;
            this.createAssessButton.Click += new System.EventHandler(this.createAssessButton_Click);
            // 
            // numericUpDownAssessment
            // 
            this.numericUpDownAssessment.Location = new System.Drawing.Point(183, 137);
            this.numericUpDownAssessment.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAssessment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAssessment.Name = "numericUpDownAssessment";
            this.numericUpDownAssessment.Size = new System.Drawing.Size(35, 20);
            this.numericUpDownAssessment.TabIndex = 20;
            this.numericUpDownAssessment.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // levelPlaceholder
            // 
            this.levelPlaceholder.AutoSize = true;
            this.levelPlaceholder.Location = new System.Drawing.Point(300, 59);
            this.levelPlaceholder.Name = "levelPlaceholder";
            this.levelPlaceholder.Size = new System.Drawing.Size(63, 13);
            this.levelPlaceholder.TabIndex = 22;
            this.levelPlaceholder.Text = "Placeholder";
            // 
            // addModuleForm
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 373);
            this.Controls.Add(this.levelPlaceholder);
            this.Controls.Add(this.numericUpDownAssessment);
            this.Controls.Add(this.createAssessButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submitModuleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moduleCodeTextbox);
            this.Controls.Add(this.moduleCodeTextLabel);
            this.Controls.Add(this.creditCombobox);
            this.Controls.Add(this.semesterCombobox);
            this.Controls.Add(this.moduleNameTextbox);
            this.Controls.Add(this.levelTextLabel);
            this.Controls.Add(this.creditsTextLabel);
            this.Controls.Add(this.semesterTextLabel);
            this.Controls.Add(this.moduleTextLabel);
            this.Name = "addModuleForm";
            this.Text = "Add Module";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssessment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moduleTextLabel;
        private System.Windows.Forms.Label semesterTextLabel;
        private System.Windows.Forms.Label creditsTextLabel;
        private System.Windows.Forms.Label levelTextLabel;
        private System.Windows.Forms.TextBox moduleNameTextbox;
        private System.Windows.Forms.ComboBox semesterCombobox;
        private System.Windows.Forms.ComboBox creditCombobox;
        private System.Windows.Forms.Label moduleCodeTextLabel;
        private System.Windows.Forms.TextBox moduleCodeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitModuleButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createAssessButton;
        private System.Windows.Forms.NumericUpDown numericUpDownAssessment;
        private System.Windows.Forms.Label levelPlaceholder;
    }
}