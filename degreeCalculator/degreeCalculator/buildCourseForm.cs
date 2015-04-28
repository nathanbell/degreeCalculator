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
