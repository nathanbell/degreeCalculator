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
        ArrayList assTextBoxes = new ArrayList();
        int length = 0;
        String ModuleLevel;
        Boolean comboPresent;
        Boolean weightTotal;
        int weightTotalInt;
        modelViewController generalController;

        public void setController(modelViewController controller)
        {
            generalController = controller;
        }     
        
        

        public addModuleForm(String level)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ModuleLevel = level;

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
                (textboxComputer[i] as TextBox).Location = p;
                (textboxComputer[i] as TextBox).Size = new System.Drawing.Size(180, 20);

                //instantiate and configure the combo boxes
                comboBoxes.Add(new ComboBox());
                System.Drawing.Point a = new System.Drawing.Point(60, 170 + i * 25);

                //config moduleWeight
                moduleWeight.Add(new ComboBox());
                System.Drawing.Point b = new System.Drawing.Point(245, 170 + i * 25);

                //to evoke an object in an ArrayList we use the 'as' keyword


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
                (moduleWeight[i] as ComboBox).Items.Add("0");
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
                (moduleWeight[i] as ComboBox).SelectedIndex = 0;


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
            comboPresent = false;
            weightTotal = false;
            weightTotalInt = 0;
            
            for (int h = 0; h < comboBoxes.Count; h++)
                {
                    if (String.IsNullOrEmpty((comboBoxes[h] as ComboBox).Text) || String.IsNullOrEmpty((moduleWeight[h] as ComboBox).Text))
                    {
                        
                        comboPresent = true;
                        
                    }
                }

            for (int i = 0; i < moduleWeight.Count; i++)
            {
                weightTotalInt += Int32.Parse((moduleWeight[i] as ComboBox).Text);
            }

            if (weightTotalInt != 100){
                weightTotal = true;
            }

            if (String.IsNullOrEmpty(moduleNameTextbox.Text) || String.IsNullOrEmpty(moduleCodeTextbox.Text))
            {
                
                    MessageBox.Show("Please make sure you input all fields.");
                
            }
           else if (moduleCodeTextbox.TextLength > 8 || moduleCodeTextbox.TextLength < 5)
           {
               MessageBox.Show("The Module Code is incorrect. The Module Code must be between 5 and 8 characters in length.");
           }
                
            else if (String.IsNullOrEmpty(creditCombobox.Text) || String.IsNullOrEmpty(semesterCombobox.Text))
            {
                MessageBox.Show("Please make sure you input all fields.");
            }

            else if (moduleWeight.Count == 0)
            {
                MessageBox.Show("You must add at least one assessment to the module.");
            }

            else if (comboPresent)
            {
                MessageBox.Show("Please make sure you input all fields.");
            }

            else if (weightTotal)
            {
                MessageBox.Show("The assessment's weights are not totally 100%. The assessments must have a combined weight of 100%.");
            }

            else
            {

                generalController.createModule(moduleNameTextbox.Text, moduleCodeTextbox.Text, length, semesterCombobox.Text, Int32.Parse(creditCombobox.Text), ModuleLevel);


                generalController.mainView.generateModule();

                Close();
                
            }

           // mainForm.Refresh();
        }

        public bool emptyFields()
        {
            if (moduleNameTextbox.TextLength < 1 || moduleCodeTextbox.TextLength < 1 /*|| string.IsNullOrEmpty(semesterCombobox.SelectedText) || string.IsNullOrEmpty(creditCombobox.SelectedText)*/) 
            {
                MessageBox.Show("Please do not leave any fields blank, all are required.");
                Console.WriteLine(moduleNameTextbox);
                Console.WriteLine(moduleCodeTextbox);
                Console.WriteLine(semesterCombobox.SelectedValue.ToString());
                Console.WriteLine(creditCombobox.SelectedValue.ToString());
                return true;

                
            }
            return true;
            
        }

        private void levelTextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
