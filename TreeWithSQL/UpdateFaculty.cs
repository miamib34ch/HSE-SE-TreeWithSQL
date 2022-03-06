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
    public partial class UpdateFaculty : Form
    {
        string id;

        public UpdateFaculty(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TreeWithSQLLab;Integrated Security=True;");
            conn.Open();
            var sqlq = $"UPDATE [dbo].[Faculty] SET [Name] = '{textBox1.Text}' WHERE [ID] = {id}";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
