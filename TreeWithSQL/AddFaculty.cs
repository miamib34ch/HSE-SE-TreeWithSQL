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
    public partial class AddFaculty : Form
    {
        public AddFaculty()
        {
            InitializeComponent();
            textBoxId.Text = $"{MainForm.facultyCount+1}";
            textBoxId.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"INSERT INTO [dbo].[Faculty] ([Id], [Name]) VALUES ({MainForm.facultyCount + 1},'{textBoxName.Text}')";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.ExecuteNonQuery();
            MainForm.facultyCount++;
            conn.Close();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
