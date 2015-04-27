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
    public partial class buildCourseForm : Form
    {
        public buildCourseForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void courseNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createCourseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.ShowDialog();
            this.Close();
            
        }
    }
}
