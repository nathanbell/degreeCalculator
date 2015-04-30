using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace degreeCalculator
{
    public partial class buildCourseForm : Form
    {
       public courseInformation userInfo;

       public buildCourseForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void courseNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void createCourseButton_Click(object sender, EventArgs e)
        {
             
            userInfo = new courseInformation();

            if (studentIdTextBox.TextLength < 7 || studentIdTextBox.TextLength > 8)
            {
                MessageBox.Show("The Student ID you have entered is incorrect." + "\n" + "Your Student ID should be 8 characters in length." + "\n" +"For example W1234567");
            }
            else if (firstNameTextBox.Text.Length < 1 || secondNameTextBox.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid first and second name.");
           
            }

            else if (courseNameComboBox.Text.Length < 5)
            {
                MessageBox.Show("Please enter a valid course name.");
            }
            
            else{

            userInfo.userFirstNameFinal = firstNameTextBox.Text;
            userInfo.userSecondName = secondNameTextBox.Text;
            userInfo.userId = studentIdTextBox.Text;
            userInfo.courseName = courseNameComboBox.Text;

            XmlTextWriter writer = new XmlTextWriter("courseDoc.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("Degree"); // <degree>
            writer.WriteStartElement("CourseName");// <CourseName>
            writer.WriteString(courseNameComboBox.Text);
            writer.WriteEndElement();// <CourseName>
            writer.WriteStartElement("Person"); // <Person>
            writer.WriteStartElement("FirstName");// <FirstName>
            writer.WriteString(firstNameTextBox.Text);
            writer.WriteEndElement();// </FirstName>
            writer.WriteStartElement("SecondName");// <SecondName>
            writer.WriteString(secondNameTextBox.Text);
            writer.WriteEndElement();// </SecondName>
            writer.WriteStartElement("StudentId");// <StudentId>
            writer.WriteString(studentIdTextBox.Text);
            writer.WriteEndElement();// </StudentId>
            writer.WriteEndElement(); // </Person>
            writer.WriteEndElement(); // </degree>
            writer.Close();

            
            this.Hide();
            mainForm main = new mainForm();
            main.ShowDialog();
            this.Close();
            }
        }
    }
}
