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
            this.tabControlPanel = new System.Windows.Forms.TabControl();
            this.tabOne = new System.Windows.Forms.TabPage();
            this.firstLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            this.buildCourseButton = new System.Windows.Forms.Button();
            this.tabThree = new System.Windows.Forms.TabPage();
            this.addFiveModuleButton = new System.Windows.Forms.Button();
            this.tabFour = new System.Windows.Forms.TabPage();
            this.addSixModuleButton = new System.Windows.Forms.Button();
            this.tabFive = new System.Windows.Forms.TabPage();
            this.addFourModuleButton = new System.Windows.Forms.Button();
            this.tabTwo = new System.Windows.Forms.TabPage();
            this.tabControlPanel.SuspendLayout();
            this.tabOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabThree.SuspendLayout();
            this.tabFour.SuspendLayout();
            this.tabTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPanel
            // 
            this.tabControlPanel.Controls.Add(this.tabOne);
            this.tabControlPanel.Controls.Add(this.tabTwo);
            this.tabControlPanel.Controls.Add(this.tabThree);
            this.tabControlPanel.Controls.Add(this.tabFour);
            this.tabControlPanel.Controls.Add(this.tabFive);
            this.tabControlPanel.Location = new System.Drawing.Point(12, 12);
            this.tabControlPanel.Name = "tabControlPanel";
            this.tabControlPanel.SelectedIndex = 0;
            this.tabControlPanel.Size = new System.Drawing.Size(818, 457);
            this.tabControlPanel.TabIndex = 0;
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
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(35, 152);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(85, 16);
            this.firstLabel.TabIndex = 3;
            this.firstLabel.Text = "Placeholder";
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
            // tabThree
            // 
            this.tabThree.Controls.Add(this.addFiveModuleButton);
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
            this.addFiveModuleButton.Location = new System.Drawing.Point(381, 394);
            this.addFiveModuleButton.Name = "addFiveModuleButton";
            this.addFiveModuleButton.Size = new System.Drawing.Size(46, 34);
            this.addFiveModuleButton.TabIndex = 2;
            this.addFiveModuleButton.Text = "+";
            this.addFiveModuleButton.UseVisualStyleBackColor = true;
            this.addFiveModuleButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabFour
            // 
            this.tabFour.Controls.Add(this.addSixModuleButton);
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
            this.addSixModuleButton.Location = new System.Drawing.Point(378, 394);
            this.addSixModuleButton.Name = "addSixModuleButton";
            this.addSixModuleButton.Size = new System.Drawing.Size(46, 34);
            this.addSixModuleButton.TabIndex = 2;
            this.addSixModuleButton.Text = "+";
            this.addSixModuleButton.UseVisualStyleBackColor = true;
            this.addSixModuleButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabFive
            // 
            this.tabFive.Location = new System.Drawing.Point(4, 22);
            this.tabFive.Name = "tabFive";
            this.tabFive.Size = new System.Drawing.Size(810, 431);
            this.tabFive.TabIndex = 4;
            this.tabFive.Text = "Summary";
            this.tabFive.UseVisualStyleBackColor = true;
            // 
            // addFourModuleButton
            // 
            this.addFourModuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFourModuleButton.Location = new System.Drawing.Point(374, 391);
            this.addFourModuleButton.Name = "addFourModuleButton";
            this.addFourModuleButton.Size = new System.Drawing.Size(46, 34);
            this.addFourModuleButton.TabIndex = 1;
            this.addFourModuleButton.Text = "+";
            this.addFourModuleButton.UseVisualStyleBackColor = true;
            this.addFourModuleButton.Click += new System.EventHandler(this.addFourModuleButton_Click);
            // 
            // tabTwo
            // 
            this.tabTwo.Controls.Add(this.addFourModuleButton);
            this.tabTwo.Location = new System.Drawing.Point(4, 22);
            this.tabTwo.Name = "tabTwo";
            this.tabTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwo.Size = new System.Drawing.Size(810, 431);
            this.tabTwo.TabIndex = 1;
            this.tabTwo.Text = "Level Four";
            this.tabTwo.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 481);
            this.Controls.Add(this.tabControlPanel);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Degree Calculator";
            this.tabControlPanel.ResumeLayout(false);
            this.tabOne.ResumeLayout(false);
            this.tabOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabThree.ResumeLayout(false);
            this.tabFour.ResumeLayout(false);
            this.tabTwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPanel;
        private System.Windows.Forms.TabPage tabOne;
        private System.Windows.Forms.Button buildCourseButton;
        private System.Windows.Forms.TabPage tabThree;
        private System.Windows.Forms.TabPage tabFour;
        private System.Windows.Forms.TabPage tabFive;
        private System.Windows.Forms.Label welcomeTextLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addFiveModuleButton;
        private System.Windows.Forms.Button addSixModuleButton;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.TabPage tabTwo;
        private System.Windows.Forms.Button addFourModuleButton;
    }
}

