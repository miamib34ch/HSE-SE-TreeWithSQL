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
    public partial class AddGroup : Form
    {
        string courseId;

        public AddGroup(string courseId)
        {
            InitializeComponent();
            textBoxId.Text = $"{MainForm.groupCount + 1}";
            textBoxId.Enabled = false;
            this.courseId = courseId;
            textBoxCourseId.Text = $"{courseId}";
            textBoxCourseId.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"INSERT INTO [dbo].[Group] ([Id], [CourseId], [GroupNumber]) VALUES ({MainForm.groupCount + 1},{courseId},{textBoxGroupNumber.Text})";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MainForm.groupCount++;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCourseNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(textBoxGroupNumber.Text, out int w) || textBoxGroupNumber.Text == "")
            {
                
            }
            else
            {
                MessageBox.Show("Вы ввели символ, вводите цифры!");
                textBoxGroupNumber.Clear();
            }
        }
    }
}
