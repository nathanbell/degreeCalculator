using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degreeCalculator
{
    public partial class addModuleForm : Form
    {

        ArrayList textboxComputer = new ArrayList();
        ArrayList labels = new ArrayList();
        ArrayList otherLabel = new ArrayList();
        ArrayList comboBoxes = new ArrayList();
        ArrayList moduleWeight = new ArrayList();
        ArrayList notesLabel = new ArrayList();
        int length = 0;
        String ModuleLevel;
       

        public addModuleForm(String level)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ModuleLevel = level;
            levelPlaceholder.Text = ModuleLevel;
        }

        private void createAssessButton_Click(object sender, EventArgs e)
        {
           length = (int)this.numericUpDownAssessment.Value;
           
           
             //populate 
            for (int i = 0; i < length; i++)
            {
                //instantiate and configure the text boxes
                textboxComputer.Add(new TextBox());
                System.Drawing.Point p = new System.Drawing.Point(340, 170 + i * 25);

                //instantiate and configure the combo boxes
                comboBoxes.Add(new ComboBox());
                System.Drawing.Point a = new System.Drawing.Point(60, 170 + i * 25);

                //config moduleWeight
                moduleWeight.Add(new ComboBox());
                System.Drawing.Point b = new System.Drawing.Point(245, 170 + i * 25);

                //to evoke an object in an ArrayList we use the 'as' keyword
                (textboxComputer[i] as TextBox).Location = p;
                (textboxComputer[i] as TextBox).Size = new System.Drawing.Size(180, 20);

                //evoke comboboxes
                (comboBoxes[i] as ComboBox).Location = a;
                (comboBoxes[i] as ComboBox).Size = new System.Drawing.Size(130, 20);
                (comboBoxes[i] as ComboBox).DropDownStyle = ComboBoxStyle.DropDownList;
                (comboBoxes[i] as ComboBox).Items.Add("Coursework");
                (comboBoxes[i] as ComboBox).Items.Add("Exam");
                (comboBoxes[i] as ComboBox).Items.Add("Portfolio");
                

                //evoke moduleWeight
                (moduleWeight[i] as ComboBox).Location = b;
                (moduleWeight[i] as ComboBox).Size = new System.Drawing.Size(45, 20);
                (moduleWeight[i] as ComboBox).DropDownStyle = ComboBoxStyle.DropDownList;
                (moduleWeight[i] as ComboBox).Items.Add("10");
                (moduleWeight[i] as ComboBox).Items.Add("20");
                (moduleWeight[i] as ComboBox).Items.Add("30");
                (moduleWeight[i] as ComboBox).Items.Add("40");
                (moduleWeight[i] as ComboBox).Items.Add("50");
                (moduleWeight[i] as ComboBox).Items.Add("60");
                (moduleWeight[i] as ComboBox).Items.Add("70");
                (moduleWeight[i] as ComboBox).Items.Add("80");
                (moduleWeight[i] as ComboBox).Items.Add("90");
                (moduleWeight[i] as ComboBox).Items.Add("100");
                

                //use 'as' again here to add the control to the controls Collection
                this.Controls.Add(textboxComputer[i] as TextBox);
                this.Controls.Add(comboBoxes[i] as ComboBox);
                this.Controls.Add(moduleWeight[i] as ComboBox);

                //instantiate and configure the labels
                this.labels.Add(new Label());
                System.Drawing.Point pLabel = new System.Drawing.Point(13, 170 + i * 25);
                (labels[i] as Label).Location = pLabel;
                (labels[i] as Label).Size = new System.Drawing.Size(80, 13);

                (labels[i] as Label).Text = (i + 1).ToString() + ". Type:";
                this.Controls.Add((labels[i] as Label));

                this.otherLabel.Add(new Label());
                System.Drawing.Point c = new System.Drawing.Point(200, 170 + i * 25);
                (otherLabel[i] as Label).Location = c;
                (otherLabel[i] as Label).Size = new System.Drawing.Size(80, 13);

                (otherLabel[i] as Label).Text = "Weight:";
                this.Controls.Add((otherLabel[i] as Label));

                this.notesLabel.Add(new Label());
                System.Drawing.Point d = new System.Drawing.Point(300, 170 + i * 25);
                (notesLabel[i] as Label).Location = d;
                (notesLabel[i] as Label).Size = new System.Drawing.Size(80, 13);

                (notesLabel[i] as Label).Text = "Notes:";
                this.Controls.Add((notesLabel[i] as Label));

                //add some mouse events
                //(textboxComputer[i] as TextBox).MouseEnter += new System.EventHandler(this.textBox_mouseEnter);
                //(textboxComputer[i] as TextBox).MouseLeave += new System.EventHandler(this.textBox_mouseLeave);

                //add the radio buttons - these are already sized  (See RadioButtons.cs) so just need to place at a point
                //radioButtons.Add(new RadioButtons());
                //(radioButtons[i] as RadioButtons).Location = new System.Drawing.Point(370, 110 + i * 25);
                //this.Controls.Add(radioButtons[i] as RadioButtons);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Assessment Details: "+textboxComputer[i]);
            }
        }

        private void submitModuleButton_Click(object sender, EventArgs e)
        {

        }

        private void levelTextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
