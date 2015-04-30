using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace degreeCalculator
{
    public partial class mainForm : Form
    {
        buildCourseForm buildForm;
        addModuleForm moduleForm;
        modelViewController generalController;
        int modNumber = 0;
        int modNumberTabTwo = 0;
        int modNumberTabThree = 0;
        int modNumberTabFour = 0;
        int increase = 0;
        int examMark = 0;
        int i = 0;
        ArrayList textLabel1 = new ArrayList();
        ArrayList assLabel = new ArrayList();
        ArrayList assTextBoxes = new ArrayList();
        ModuleModel theModule;
        
        public mainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //tabControlPanel.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexchanged);
            String xmlFile = "courseDoc.xml";
            XmlDocument xDoc = new XmlDocument();

            if (File.Exists(xmlFile))
            {
                xDoc.Load(xmlFile);
                String userName = xDoc.SelectSingleNode("Degree/Person/FirstName").InnerText;
                String userSecondName = xDoc.SelectSingleNode("Degree/Person/SecondName").InnerText;
                String userId = xDoc.SelectSingleNode("Degree/Person/StudentId").InnerText;
                String userCourseName = xDoc.SelectSingleNode("Degree/CourseName").InnerText;
                firstLabel.Text = "Name: " + userName + " " + userSecondName + "\n" + "\n" + "User Id: " + userId + "\n" + "\n" + "Course: " + userCourseName;
                buildCourseButton.Visible = false;
            }
            else
            {
                Console.WriteLine("The file {0} could not be located",
                                  xmlFile);
                firstLabel.Text = "There is currently not a course present." + "\n" + "To create a course, please click the 'Build Course' button.";
            }

        }

        public void setController(modelViewController controller)
        {
            generalController = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            buildForm = new buildCourseForm();
            buildForm.Activate();
            buildForm.Show();
        }
        
        private void addFourModuleButton_Click(object sender, EventArgs e)
        {
            String levelToAddFour = "Four";
            moduleForm = new addModuleForm(levelToAddFour);
            moduleForm.setController(generalController);
            moduleForm.Show();

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            String levelToAddFive = "Five";
            moduleForm = new addModuleForm(levelToAddFive);
            moduleForm.setController(generalController);
            moduleForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String levelToAddSix = "Six";
            moduleForm = new addModuleForm(levelToAddSix);
            moduleForm.setController(generalController);
            moduleForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void generateModule()
        {

            
            theModule = generalController.getTheModule(modNumber);

            if (theModule.ModuleLevel.Equals("Four"))
            {
                this.textLabel1.Add(new Label());
                System.Drawing.Point p = new System.Drawing.Point(20, 50 + modNumberTabTwo * 50);
                (textLabel1[modNumber] as Label).Location = p;
                (textLabel1[modNumber] as Label).Size = new System.Drawing.Size(300, 20);
                (textLabel1[modNumber] as Label).Text = theModule.ModuleCode + ": " + theModule.Name + " - " + theModule.ModuleCredits + " Credits - SEM: " + theModule.ModuleSemester;
                this.tabTwo.Controls.Add((textLabel1[modNumber] as Label));


                //for (int i = 0; i < theModule.NumberOfAssessments; i++)
                //{
                //    this.assLabel.Add(new Label());
                //    System.Drawing.Point a = new System.Drawing.Point(20, 50 + modNumberTabTwo * 50);
                //    (assLabel[modNumber] as Label).Location = a;
                //    (assLabel[modNumber] as Label).Size = new System.Drawing.Size(300, 20);
                //    (assLabel[modNumber] as Label).Text = "Hi";
                //    this.tabTwo.Controls.Add((assLabel[modNumber] as Label));
                //    Console.WriteLine(theModule.NumberOfAssessments);
                //    createAssessmentTextboxes(modNumberTabTwo);
                //    modNumberTabTwo++;   
                //}           
                createAssessmentTextboxes(modNumberTabTwo);
                modNumberTabTwo++;
            }
            else if (theModule.ModuleLevel.Equals("Five"))
            {
                
                this.textLabel1.Add(new Label());
                System.Drawing.Point p = new System.Drawing.Point(20, 50 + modNumberTabThree * 50);
                (textLabel1[modNumber] as Label).Location = p;
                (textLabel1[modNumber] as Label).Size = new System.Drawing.Size(300, 20);
                (textLabel1[modNumber] as Label).Text = theModule.ModuleCode + ": " + theModule.Name + " - " + theModule.ModuleCredits + " Credits - SEM: " + theModule.ModuleSemester;
                this.tabThree.Controls.Add((textLabel1[modNumber] as Label));
                createAssessmentTextboxes(modNumberTabThree);
                modNumberTabThree++;
            }
            else if (theModule.ModuleLevel.Equals("Six"))
            {
               
                this.textLabel1.Add(new Label());
                System.Drawing.Point p = new System.Drawing.Point(20, 50 + modNumberTabFour * 50);
                (textLabel1[modNumber] as Label).Location = p;
                (textLabel1[modNumber] as Label).Size = new System.Drawing.Size(300, 20);
                (textLabel1[modNumber] as Label).Text = theModule.ModuleCode + ": " + theModule.Name + " - " + theModule.ModuleCredits + " Credits - SEM: " + theModule.ModuleSemester;
                this.tabFour.Controls.Add((textLabel1[modNumber] as Label));
                createAssessmentTextboxes(modNumberTabFour);
                modNumberTabFour++;
            }
            modNumber++;
        }

        public void createAssessmentTextboxes(int x)
        {
            
            theModule = generalController.getTheModule(modNumber);
            for (int i = 0; i < theModule.NumberOfAssessments; i++)
            {
                //Add textboxes
                if (theModule.ModuleLevel.Equals("Four"))
                {
                    assTextBoxes.Add(new TextBox());
                    System.Drawing.Point g = new System.Drawing.Point(350 + increase, 50 + x * 50);
                    (assTextBoxes[examMark] as TextBox).Location = g;
                    (assTextBoxes[examMark] as TextBox).Size = new System.Drawing.Size(30, 20);
                    this.tabTwo.Controls.Add(assTextBoxes[examMark] as TextBox);
                    increase += 100;
                    examMark++;
                }

                if (theModule.ModuleLevel.Equals("Five"))
                {
                    assTextBoxes.Add(new TextBox());
                    System.Drawing.Point g = new System.Drawing.Point(350 + increase, 50 + x * 50);
                    (assTextBoxes[examMark] as TextBox).Location = g;
                    (assTextBoxes[examMark] as TextBox).Size = new System.Drawing.Size(30, 20);
                    this.tabThree.Controls.Add(assTextBoxes[examMark] as TextBox);
                    increase += 100;
                    examMark++;
                }

                if (theModule.ModuleLevel.Equals("Six"))
                {
                    assTextBoxes.Add(new TextBox());
                    System.Drawing.Point g = new System.Drawing.Point(350 + increase, 50 + x * 50);
                    (assTextBoxes[examMark] as TextBox).Location = g;
                    (assTextBoxes[examMark] as TextBox).Size = new System.Drawing.Size(30, 20);
                    this.tabFour.Controls.Add(assTextBoxes[examMark] as TextBox);
                    increase += 100;
                    examMark++;
                }
            }
            increase = 0;
        }
    }


}
