namespace degreeCalculator
{
    partial class mainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOne = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            this.buildCourseButton = new System.Windows.Forms.Button();
            this.tabTwo = new System.Windows.Forms.TabPage();
            this.addFourModuleButton = new System.Windows.Forms.Button();
            this.levelFourLabel = new System.Windows.Forms.Label();
            this.tabThree = new System.Windows.Forms.TabPage();
            this.addFiveModuleButton = new System.Windows.Forms.Button();
            this.levelFiveLabel = new System.Windows.Forms.Label();
            this.tabFour = new System.Windows.Forms.TabPage();
            this.addSixModuleButton = new System.Windows.Forms.Button();
            this.levelSixLabel = new System.Windows.Forms.Label();
            this.tabFive = new System.Windows.Forms.TabPage();
            this.summaryTitleLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabTwo.SuspendLayout();
            this.tabThree.SuspendLayout();
            this.tabFour.SuspendLayout();
            this.tabFive.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOne);
            this.tabControl1.Controls.Add(this.tabTwo);
            this.tabControl1.Controls.Add(this.tabThree);
            this.tabControl1.Controls.Add(this.tabFour);
            this.tabControl1.Controls.Add(this.tabFive);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOne
            // 
            this.tabOne.Controls.Add(this.firstLabel);
            this.tabOne.Controls.Add(this.pictureBox1);
            this.tabOne.Controls.Add(this.welcomeTextLabel);
            this.tabOne.Controls.Add(this.buildCourseButton);
            this.tabOne.Location = new System.Drawing.Point(4, 22);
            this.tabOne.Name = "tabOne";
            this.tabOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabOne.Size = new System.Drawing.Size(810, 431);
            this.tabOne.TabIndex = 0;
            this.tabOne.Text = "Home";
            this.tabOne.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::degreeCalculator.Properties.Resources.logofinal;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 124);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // welcomeTextLabel
            // 
            this.welcomeTextLabel.AutoSize = true;
            this.welcomeTextLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextLabel.Location = new System.Drawing.Point(35, 117);
            this.welcomeTextLabel.Name = "welcomeTextLabel";
            this.welcomeTextLabel.Size = new System.Drawing.Size(234, 16);
            this.welcomeTextLabel.TabIndex = 1;
            this.welcomeTextLabel.Text = "Welcome to the Degree Calculator. ";
            this.welcomeTextLabel.Click += new System.EventHandler(this.welcomeTextLabel_Click);
            // 
            // buildCourseButton
            // 
            this.buildCourseButton.Location = new System.Drawing.Point(38, 392);
            this.buildCourseButton.Name = "buildCourseButton";
            this.buildCourseButton.Size = new System.Drawing.Size(75, 23);
            this.buildCourseButton.TabIndex = 0;
            this.buildCourseButton.Text = "Build Course";
            this.buildCourseButton.UseVisualStyleBackColor = true;
            this.buildCourseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabTwo
            // 
            this.tabTwo.Controls.Add(this.addFourModuleButton);
            this.tabTwo.Controls.Add(this.levelFourLabel);
            this.tabTwo.Location = new System.Drawing.Point(4, 22);
            this.tabTwo.Name = "tabTwo";
            this.tabTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwo.Size = new System.Drawing.Size(810, 431);
            this.tabTwo.TabIndex = 1;
            this.tabTwo.Text = "Level Four";
            this.tabTwo.UseVisualStyleBackColor = true;
            // 
            // addFourModuleButton
            // 
            this.addFourModuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFourModuleButton.Location = new System.Drawing.Point(387, 381);
            this.addFourModuleButton.Name = "addFourModuleButton";
            this.addFourModuleButton.Size = new System.Drawing.Size(46, 34);
            this.addFourModuleButton.TabIndex = 1;
            this.addFourModuleButton.Text = "+";
            this.addFourModuleButton.UseVisualStyleBackColor = true;
            this.addFourModuleButton.Click += new System.EventHandler(this.addFourModuleButton_Click);
            // 
            // levelFourLabel
            // 
            this.levelFourLabel.AutoSize = true;
            this.levelFourLabel.Location = new System.Drawing.Point(20, 21);
            this.levelFourLabel.Name = "levelFourLabel";
            this.levelFourLabel.Size = new System.Drawing.Size(100, 13);
            this.levelFourLabel.TabIndex = 0;
            this.levelFourLabel.Text = "Level Four Modules";
            this.levelFourLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabThree
            // 
            this.tabThree.Controls.Add(this.addFiveModuleButton);
            this.tabThree.Controls.Add(this.levelFiveLabel);
            this.tabThree.Location = new System.Drawing.Point(4, 22);
            this.tabThree.Name = "tabThree";
            this.tabThree.Size = new System.Drawing.Size(810, 431);
            this.tabThree.TabIndex = 2;
            this.tabThree.Text = "Level Five";
            this.tabThree.UseVisualStyleBackColor = true;
            // 
            // addFiveModuleButton
            // 
            this.addFiveModuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFiveModuleButton.Location = new System.Drawing.Point(389, 385);
            this.addFiveModuleButton.Name = "addFiveModuleButton";
            this.addFiveModuleButton.Size = new System.Drawing.Size(46, 34);
            this.addFiveModuleButton.TabIndex = 2;
            this.addFiveModuleButton.Text = "+";
            this.addFiveModuleButton.UseVisualStyleBackColor = true;
            this.addFiveModuleButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // levelFiveLabel
            // 
            this.levelFiveLabel.AutoSize = true;
            this.levelFiveLabel.Location = new System.Drawing.Point(19, 21);
            this.levelFiveLabel.Name = "levelFiveLabel";
            this.levelFiveLabel.Size = new System.Drawing.Size(99, 13);
            this.levelFiveLabel.TabIndex = 0;
            this.levelFiveLabel.Text = "Level Five Modules";
            this.levelFiveLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabFour
            // 
            this.tabFour.Controls.Add(this.addSixModuleButton);
            this.tabFour.Controls.Add(this.levelSixLabel);
            this.tabFour.Location = new System.Drawing.Point(4, 22);
            this.tabFour.Name = "tabFour";
            this.tabFour.Size = new System.Drawing.Size(810, 431);
            this.tabFour.TabIndex = 3;
            this.tabFour.Text = "Level Six";
            this.tabFour.UseVisualStyleBackColor = true;
            // 
            // addSixModuleButton
            // 
            this.addSixModuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSixModuleButton.Location = new System.Drawing.Point(386, 385);
            this.addSixModuleButton.Name = "addSixModuleButton";
            this.addSixModuleButton.Size = new System.Drawing.Size(46, 34);
            this.addSixModuleButton.TabIndex = 2;
            this.addSixModuleButton.Text = "+";
            this.addSixModuleButton.UseVisualStyleBackColor = true;
            this.addSixModuleButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // levelSixLabel
            // 
            this.levelSixLabel.AutoSize = true;
            this.levelSixLabel.Location = new System.Drawing.Point(20, 19);
            this.levelSixLabel.Name = "levelSixLabel";
            this.levelSixLabel.Size = new System.Drawing.Size(93, 13);
            this.levelSixLabel.TabIndex = 0;
            this.levelSixLabel.Text = "Level Six Modules";
            // 
            // tabFive
            // 
            this.tabFive.Controls.Add(this.summaryTitleLabel);
            this.tabFive.Location = new System.Drawing.Point(4, 22);
            this.tabFive.Name = "tabFive";
            this.tabFive.Size = new System.Drawing.Size(810, 431);
            this.tabFive.TabIndex = 4;
            this.tabFive.Text = "Summary";
            this.tabFive.UseVisualStyleBackColor = true;
            // 
            // summaryTitleLabel
            // 
            this.summaryTitleLabel.AutoSize = true;
            this.summaryTitleLabel.Location = new System.Drawing.Point(20, 18);
            this.summaryTitleLabel.Name = "summaryTitleLabel";
            this.summaryTitleLabel.Size = new System.Drawing.Size(98, 13);
            this.summaryTitleLabel.TabIndex = 0;
            this.summaryTitleLabel.Text = "Summary of Course";
            this.summaryTitleLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(35, 152);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(85, 16);
            this.firstLabel.TabIndex = 3;
            this.firstLabel.Text = "Placeholder";
            this.firstLabel.Click += new System.EventHandler(this.firstLabel_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 481);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Degree Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabOne.ResumeLayout(false);
            this.tabOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabTwo.ResumeLayout(false);
            this.tabTwo.PerformLayout();
            this.tabThree.ResumeLayout(false);
            this.tabThree.PerformLayout();
            this.tabFour.ResumeLayout(false);
            this.tabFour.PerformLayout();
            this.tabFive.ResumeLayout(false);
            this.tabFive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOne;
        private System.Windows.Forms.Button buildCourseButton;
        private System.Windows.Forms.TabPage tabTwo;
        private System.Windows.Forms.TabPage tabThree;
        private System.Windows.Forms.TabPage tabFour;
        private System.Windows.Forms.TabPage tabFive;
        private System.Windows.Forms.Label levelFourLabel;
        private System.Windows.Forms.Label levelFiveLabel;
        private System.Windows.Forms.Label levelSixLabel;
        private System.Windows.Forms.Label summaryTitleLabel;
        private System.Windows.Forms.Label welcomeTextLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addFourModuleButton;
        private System.Windows.Forms.Button addFiveModuleButton;
        private System.Windows.Forms.Button addSixModuleButton;
        private System.Windows.Forms.Label firstLabel;
    }
}

