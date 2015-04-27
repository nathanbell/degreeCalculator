using System;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            buildCourseForm buildForm = new buildCourseForm();
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
            addModuleForm addModule = new addModuleForm();
            addModule.Show();
        }

        private void addFiveModuleButton_Click(object sender, EventArgs e)
        {
            addModuleForm addModule = new addModuleForm();
            addModule.Show();
        }

        private void addSixModuleButton_Click(object sender, EventArgs e)
        {
            addModuleForm addModule = new addModuleForm();
            addModule.Show();
        }
    }
}
