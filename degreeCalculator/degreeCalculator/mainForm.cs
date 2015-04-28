using System;
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


        public mainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            String xmlFile = "courseDoc.xml";
            XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("courseDoc.xml");


            if (File.Exists(xmlFile))
            {
                xDoc.Load(xmlFile);
                String userName = xDoc.SelectSingleNode("Degree/Person/FirstName").InnerText;
                String userSecondName = xDoc.SelectSingleNode("Degree/Person/SecondName").InnerText;
                String userId = xDoc.SelectSingleNode("Degree/Person/StudentId").InnerText;
                String userCourseName = xDoc.SelectSingleNode("Degree/CourseName").InnerText;
                Console.WriteLine("User's Name: " + userName);
                firstLabel.Text = "Name: " + userName + " " + userSecondName + "\n" + "\n" + "User Id: " + userId + "\n" + "\n" + "Course: " + userCourseName;
                buildCourseButton.Visible = false;
            }
            else { 
                Console.WriteLine("The file {0} could not be located",
                                  xmlFile);
                firstLabel.Text = "There is currently not a course present." + "\n" + "To create a course, please click the 'Build Course' button.";

        }
            
            

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            buildForm = new buildCourseForm();
            buildForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void welcomeTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void addFourModuleButton_Click(object sender, EventArgs e)
        {
            String levelToAddFour = "Four";
            addModuleForm addModule = new addModuleForm(levelToAddFour);
            addModule.Show();
        }

        private void firstLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String levelToAddFive = "Five";
            addModuleForm addModule = new addModuleForm(levelToAddFive);
            addModule.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String levelToAddSix = "Six";
            addModuleForm addModule = new addModuleForm(levelToAddSix);
            addModule.Show();
        }
    }
}
