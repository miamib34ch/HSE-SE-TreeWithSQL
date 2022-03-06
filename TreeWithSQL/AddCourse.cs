using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TreeWithSQL
{
    public partial class AddCourse : Form
    {
        string facultyId;

        public AddCourse(string facultyId)
        {
            InitializeComponent();
            textBoxId.Text = $"{MainForm.courseCount + 1}";
            textBoxId.Enabled = false;
            this.facultyId = facultyId;
            textBoxFacultyId.Text = $"{facultyId}";
            textBoxFacultyId.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"INSERT INTO [dbo].[Course] ([Id], [FacultyId], [CourseNumber]) VALUES ({MainForm.courseCount+1},{facultyId},{textBoxCourseNumber.Text})";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MainForm.courseCount++;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCourseNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(textBoxCourseNumber.Text, out int w) || textBoxCourseNumber.Text == "")
            {
                
            }
            else
            {
                MessageBox.Show("Вы ввели символ, вводите цифры!");
                textBoxCourseNumber.Clear();
            }
        }
    }
}
