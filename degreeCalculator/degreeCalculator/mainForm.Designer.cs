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
            this.tabTwo = new System.Windows.Forms.TabPage();
            this.tabThree = new System.Windows.Forms.TabPage();
            this.tabFour = new System.Windows.Forms.TabPage();
            this.tabFive = new System.Windows.Forms.TabPage();
            this.buildCourseButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabOne.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(472, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOne
            // 
            this.tabOne.Controls.Add(this.buildCourseButton);
            this.tabOne.Location = new System.Drawing.Point(4, 22);
            this.tabOne.Name = "tabOne";
            this.tabOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabOne.Size = new System.Drawing.Size(464, 365);
            this.tabOne.TabIndex = 0;
            this.tabOne.Text = "Home";
            this.tabOne.UseVisualStyleBackColor = true;
            // 
            // tabTwo
            // 
            this.tabTwo.Location = new System.Drawing.Point(4, 22);
            this.tabTwo.Name = "tabTwo";
            this.tabTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwo.Size = new System.Drawing.Size(464, 365);
            this.tabTwo.TabIndex = 1;
            this.tabTwo.Text = "Level Four";
            this.tabTwo.UseVisualStyleBackColor = true;
            // 
            // tabThree
            // 
            this.tabThree.Location = new System.Drawing.Point(4, 22);
            this.tabThree.Name = "tabThree";
            this.tabThree.Size = new System.Drawing.Size(464, 365);
            this.tabThree.TabIndex = 2;
            this.tabThree.Text = "Level Five";
            this.tabThree.UseVisualStyleBackColor = true;
            // 
            // tabFour
            // 
            this.tabFour.Location = new System.Drawing.Point(4, 22);
            this.tabFour.Name = "tabFour";
            this.tabFour.Size = new System.Drawing.Size(464, 365);
            this.tabFour.TabIndex = 3;
            this.tabFour.Text = "Level Six";
            this.tabFour.UseVisualStyleBackColor = true;
            // 
            // tabFive
            // 
            this.tabFive.Location = new System.Drawing.Point(4, 22);
            this.tabFive.Name = "tabFive";
            this.tabFive.Size = new System.Drawing.Size(464, 365);
            this.tabFive.TabIndex = 4;
            this.tabFive.Text = "Summary";
            this.tabFive.UseVisualStyleBackColor = true;
            // 
            // buildCourseButton
            // 
            this.buildCourseButton.Location = new System.Drawing.Point(19, 17);
            this.buildCourseButton.Name = "buildCourseButton";
            this.buildCourseButton.Size = new System.Drawing.Size(75, 23);
            this.buildCourseButton.TabIndex = 0;
            this.buildCourseButton.Text = "Build Course";
            this.buildCourseButton.UseVisualStyleBackColor = true;
            this.buildCourseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 415);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Degree Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabOne.ResumeLayout(false);
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
    }
}

