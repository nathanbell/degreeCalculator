namespace degreeCalculator
{
    partial class buildCourseForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courseNameComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.studentDetailsLabel = new System.Windows.Forms.Label();
            this.courseDetailsLabel = new System.Windows.Forms.Label();
            this.createCourseButton = new System.Windows.Forms.Button();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::degreeCalculator.Properties.Resources.banner_logo_university_of_westminster;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(3, -77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 232);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // courseNameComboBox
            // 
            this.courseNameComboBox.FormattingEnabled = true;
            this.courseNameComboBox.Items.AddRange(new object[] {
            "Computer Science BSc Honours",
            "Computer Network Security BSc Honours",
            "Computer Networks and Communications BSc Honours",
            "Computer Systems Engineering BEng Honours",
            "Computer Systems Engineering BSc Honours",
            "Computer Systems Engineering MEng",
            "Software Engineering BEng Honours",
            "Software Engineering MEng"});
            this.courseNameComboBox.Location = new System.Drawing.Point(115, 271);
            this.courseNameComboBox.Name = "courseNameComboBox";
            this.courseNameComboBox.Size = new System.Drawing.Size(191, 21);
            this.courseNameComboBox.TabIndex = 1;
            this.courseNameComboBox.SelectedIndexChanged += new System.EventHandler(this.courseNameComboBox_SelectedIndexChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(114, 178);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(114, 200);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.secondNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(51, 178);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(33, 200);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(75, 13);
            this.secondNameLabel.TabIndex = 5;
            this.secondNameLabel.Text = "Second Name";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(34, 274);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(71, 13);
            this.courseNameLabel.TabIndex = 6;
            this.courseNameLabel.Text = "Course Name";
            // 
            // studentDetailsLabel
            // 
            this.studentDetailsLabel.AutoSize = true;
            this.studentDetailsLabel.Location = new System.Drawing.Point(13, 162);
            this.studentDetailsLabel.Name = "studentDetailsLabel";
            this.studentDetailsLabel.Size = new System.Drawing.Size(79, 13);
            this.studentDetailsLabel.TabIndex = 7;
            this.studentDetailsLabel.Text = "Student Details";
            // 
            // courseDetailsLabel
            // 
            this.courseDetailsLabel.AutoSize = true;
            this.courseDetailsLabel.Location = new System.Drawing.Point(17, 250);
            this.courseDetailsLabel.Name = "courseDetailsLabel";
            this.courseDetailsLabel.Size = new System.Drawing.Size(75, 13);
            this.courseDetailsLabel.TabIndex = 8;
            this.courseDetailsLabel.Text = "Course Details";
            // 
            // createCourseButton
            // 
            this.createCourseButton.Location = new System.Drawing.Point(19, 338);
            this.createCourseButton.Name = "createCourseButton";
            this.createCourseButton.Size = new System.Drawing.Size(102, 23);
            this.createCourseButton.TabIndex = 9;
            this.createCourseButton.Text = "Create Course";
            this.createCourseButton.UseVisualStyleBackColor = true;
            this.createCourseButton.Click += new System.EventHandler(this.createCourseButton_Click);
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(47, 224);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(58, 13);
            this.studentIdLabel.TabIndex = 10;
            this.studentIdLabel.Text = "Student ID";
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(114, 221);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(192, 20);
            this.studentIdTextBox.TabIndex = 11;
            // 
            // buildCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 376);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.createCourseButton);
            this.Controls.Add(this.courseDetailsLabel);
            this.Controls.Add(this.studentDetailsLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.courseNameComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "buildCourseForm";
            this.Text = "Build Your Course";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox courseNameComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label studentDetailsLabel;
        private System.Windows.Forms.Label courseDetailsLabel;
        private System.Windows.Forms.Button createCourseButton;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.TextBox studentIdTextBox;
    }
}